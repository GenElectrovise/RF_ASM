grammar RedFoxAssembly;

program
	: (configurations+=configuration)+ (commands+=command)+ eof=EOF
	;

// Configuration

configuration
	: width SemiColon  #WidthConfiguration
	| value SemiColon  #ValueConfiguration
	;

width
	: Width val=Digit
	;

value
	: WordValue id=Identifier Comma wordValue=word
	| ByteValue id=Identifier Comma byteValue=byte
	;

// Instructions

command
	: label SemiColon         #LabelCommand
	| instruction SemiColon   #InstructionCommand
	;

label
	: LabelStart id=Identifier
	;

instruction
	: hlt #HLTInstruction
	| nop #NOPInstruction
	| add #ADDInstruction
	| sub #SUBInstruction
	| lsl #LSLInstruction
	| lsr #LSRInstruction
	| neg #NEGInstruction
	| not #NOTInstruction
	| cmp #CMPInstruction
	| jmp #JMPInstruction
	| bfg #BFGInstruction
	//| lsl #LSLInstruction
	//| lsl #LSLInstruction
	//| lsl #LSLInstruction
	| bsr #BSRInstruction
	| rtn #RTNInstruction
	| rrb #RRBInstruction
	| rrw #RRWInstruction
	| rmb #RMBInstruction
	| rmw #RMWInstruction
	| wrb #WRBInstruction
	| wrw #WRWInstruction
	| wmb #WMBInstruction
	| wmw #WMWInstruction
	| rvb #RVBInstruction
	| rvw #RVWInstruction
	| sin #SINInstruction
	| int #INTInstruction
	| sfg #SFGInstruction
	| and #ANDInstruction
	| lor #LORInstruction
	| xor #XORInstruction
	;

hlt: op=HLT;
nop: op=NOP;
add: op=ADD;
sub: op=SUB;
lsl: op=LSL;
lsr: op=LSR;
neg: op=NEG;
not: op=NOT;
cmp: op=CMP;
jmp: op=JMP arg1w=word;
bfg: op=BFG arg1w=word arg2b=byte;
//
//
//
bsr: op=BSR arg1w=word;
rtn: op=RTN;
rrb: op=RRB arg1b=byte Comma arg2b=byte;
rrw: op=RRW arg1b=byte;
rmb: op=RMB arg1w=word;
rmw: op=RMW arg1w=word;
wrb: op=WRB arg1b=byte Comma arg2b=byte;
wrw: op=WRW arg1b=byte;
wmb: op=WMB arg1w=word;
wmw: op=WMW arg1w=word;
rvb: op=RVB arg1b=byte;
rvw: op=RVW arg1w=word;
sin: op=SIN arg1w=word Comma arg2b=byte;
int: op=INT arg1b=byte;
sfg: op=SFG arg1b=byte Comma arg2b=byte;
and: op=AND;
lor: op=LOR;
xor: op=XOR;

// Data

word
	: isHex=HexPrefix (hexData+=bytedata)+
	| registerTarget=RegisterPrefix registerData=bytedata
	| val=Identifier
	;

byte
	: isHex=HexPrefix hexData=bytedata
	| registerTarget=RegisterPrefix registerData=bytedata
	| val=Identifier
	;

bytedata
	: (ByteLetter | Digit) (ByteLetter | Digit)
	;


// ===== LEXER =====

LabelStart: '::';
Width: '.width';
WordValue: '.word';
ByteValue: '.byte';

HLT: 'HLT';
NOP: 'NOP';
ADD: 'ADD';
SUB: 'SUB';
LSL: 'LSL';
LSR: 'LSR';
NEG: 'NEG';
NOT: 'NOT';
CMP: 'CMP';
JMP: 'JMP';
BFG: 'BFG';
// HLT: 'HLT';
// HLT: 'HLT';
// HLT: 'HLT';
BSR: 'BSR';
RTN: 'RTN';
RRB: 'RRB';
RRW: 'RRW';
RMB: 'RMB';
RMW: 'RMW';
WRB: 'WRB';
WRW: 'WRW';
WMB: 'WMB';
WMW: 'WMW';
RVB: 'RVB';
RVW: 'RVW';
SIN: 'SIN';
INT: 'INT';
SFG: 'SFG';
AND: 'AND';
LOR: 'LOR';
XOR: 'XOR';

RegisterPrefix
	: Register 
	| GeneralRegister 
	| ComponentRegister 
	| SpecialisedRegister
	;
fragment Register: 'Rx';
fragment GeneralRegister: 'Gx';
fragment ComponentRegister: 'Cx';
fragment SpecialisedRegister: 'Sx';
HexPrefix: '0x';

Underscore: '_'; 
Quote: '\'';
Comma: ',';
SemiColon: ';';

Digit: [0-9];
ByteLetter: [a-fA-F];

Identifier
    : Underscore (Alphabetic | Digit | Underscore)+ Underscore
    ;
SkipTokens
    : (WhiteSpace | Newline | LineComment) -> skip
    ;
LineComment 
    : '//' ~('\r' | '\n')*
    ;
fragment Alphabetic
    : [a-zA-Z]
    ;
fragment WhiteSpace
    : [ \t]+
    ;
fragment Newline
    : [\r\n]+
    | EOF
    ;