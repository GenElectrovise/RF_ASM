Code     Hex   Info
HLT      00    Immediately stop the execution of instructions. Next instruction will not be read.
LDA α    01    Load the value from α to the A register.
LDB α    02    Load the value from α to the B register.
ADD      03    Add the values in registers A and B, and store the result in C.
SUB      04    Subtract the value of register B from A and store the result in C.
CMP α,β  05    Compare value at α to β.
B α      06    Jump to the memory address at α.
BEQ α    07    If CMP returns equal, jump to the memory address at α.
BNE α    08    If CMP returns not equal, jump to the memory address at α.
BGT α    09    If CMP returns greater than, jump to the memory address at α.
BSR α    0A    Push the next memory address to Stack, and jump to the memory address at α.
RTN      0B    Jump to the last memory address in stack, and remove it.
LDR α,β  0C    Load the value from β into the register α.
CTM α    0D    Move the value in C to the memory address at α.
RTM α,β  0E    Move the value from register α to the memory address at β.
         0F    