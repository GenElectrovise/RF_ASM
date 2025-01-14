﻿using System.Text.Json;
using System.Text.RegularExpressions;
using NLog;
using RedFoxAssembly.Statements;

namespace RedFoxAssembly.Core
{
    /// <summary>
    /// Compiler for converting a list of RF ASM instructions into binary for interpretation. 
    /// Each instruction (for example, "LDA 0xaf") should be on a new line, and arguments are seperated by a space.
    /// </summary>
    class RFASMCompiler
    {
        private static readonly Logger LOGGER = LogManager.GetCurrentClassLogger();

        internal Dictionary<string, LabelCommand> Labels { get; set; }
        internal Dictionary<string, IData> Constants { get; set; }

        public RFASMOptions Options { get; set; }

        public RFASMCompiler (RFASMOptions options)
        {
            Options = options;
            Labels = new Dictionary<string, LabelCommand>();
            Constants = new Dictionary<string, IData>();
        }

        public int Compile (RFASMProgram program)
        {
            if (!File.Exists(Options.MetadataPath)) throw new FileNotFoundException("Could not file metadata file: " + Options.MetadataPath);
            LOGGER.Info("Reading metadata file: " + Options.MetadataPath);
            string metadataJson = File.ReadAllText(Options.MetadataPath);
            if (string.IsNullOrWhiteSpace(metadataJson)) throw new JsonException("Found null-or-whitespace JSON in metadata file");
            program.ReloadSerialMetadata(metadataJson);

            // <==> Compiling
            Console.WriteLine("");
            Console.WriteLine(" <==> Compiling");

            Console.WriteLine("Doing pre-compilation pass");
            PreCompilationPass(program);
            Console.WriteLine("Bytifying");
            List<byte> compiledBytes = CompileTokens(program);

            Console.WriteLine("Generated bytes:");
            CompilerUtils.DisplayHexDump(compiledBytes.ToArray());

            // <==> Writing
            Console.WriteLine("");
            Console.WriteLine(" <==> Writing");
            WriteCompilation(Options.SourcePath, compiledBytes.ToArray());

            Console.WriteLine("");
            Console.WriteLine(" <==> Done");
            Console.WriteLine(" <==> https://github.com/gamesmaster3000x/RF_ASM");
            Console.WriteLine(" <==> RFASM Compiler, by GenElectrovise for Gamesmaster3000X");
            Console.WriteLine("");

            return 0;
        }

        private void PreCompilationPass (RFASMProgram program)
        {
            // Resolve configuration (i.e. data widths and values)
            foreach (var c in program.Configuations)
            {
                c.Resolve(this);
            }

            program.Commands.Insert(0, new InstructionCommand(InstructionType.JMP, new Word(false, "_END_COMPILER_METADATA_"), null));
            program.Commands.Insert(1, new InstructionCommand(InstructionType.NOP, null, null));
            program.Commands.Insert(2, new LabelCommand("_END_COMPILER_METADATA_"));

            int programLength = 0;
            // Resolve labels
            foreach (var c in program.Commands)
            {
                if (c is LabelCommand command)
                {
                    command.DeclareLabel(this, programLength);
                }
                else
                {
                    programLength += c.GetPredictedLength(this);
                }
            }

            // Collect names and widths of labels, values, etc.
            // to be able to calculate metadata predicted width
            int metaLength = program.Metadata.GetPredictedLength(this);
            foreach (var l in Labels.Values)
            {
                l.Position += metaLength;
            }
        }

        private List<byte> CompileTokens (RFASMProgram program)
        {
            List<byte> compiledBytes = new List<byte>();

            foreach (var c in program.Commands)
            {
                if (c is not LabelCommand)
                {
                    compiledBytes.AddRange(c.GetBytes(this));
                }
            }

            compiledBytes.InsertRange(1 + Options!.DataWidth, program.Metadata.GetBytes(this));

            return compiledBytes;
        }

        private void WriteCompilation (string inputPath, byte[] bytes)
        {
            string outputPath = GetOutputFileName(inputPath);
            FileInfo outputFileInfo = new FileInfo(outputPath);
            Console.WriteLine("Storing compilation to " + outputFileInfo.FullName);
            if (File.Exists(outputPath)) File.Delete(outputPath);
            BinaryWriter writer = new BinaryWriter(File.Open(outputPath, FileMode.OpenOrCreate));
            writer.Write(bytes);
            writer.Flush();
            writer.Close();
        }

        private string GetInputFilePath ()
        {
            Console.Write("Enter the name of the file to be compiled (including the file extension): ");
            string inputPath = Console.ReadLine();
            FileInfo inputFileInfo = new FileInfo(inputPath);
            if (!inputFileInfo.Exists)
            {
                throw new FileNotFoundException("Cannot file the file " + inputFileInfo.FullName);
            }

            return inputPath;
        }

        /// <summary>
        /// Generates the name of the output file based on the input file. For example Program.rfx will become Program.rfbin.
        /// </summary>
        /// <param name="inputFileName"></param>
        /// <returns></returns>
        public string GetOutputFileName (string inputFileName)
        {
            // The input file extension and output file extension
            string RF_BIN_FileEnding = "rfb";

            // Fancy regular expression stuff to replace the .input with the .output
            // () are a class
            // Searches for the final . , then takes everything after it and replaces with the new file ending
            return Regex.Replace(inputFileName, "([^.]+$)", RF_BIN_FileEnding);
        }
    }
}
