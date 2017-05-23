# Control EEPROM contents

The first Excel sheets shows the contents of my EEPROM.
My circuit is a little different from Ben Eater's because I'm routing the signals from T0 and T1 through an AND gate, combines with the instruction signals.
That way the instruction is only send to the address lines when T0 and T1 are both zero and I don't have to program T0 and T1 logic for each instruction.

The 2nd sheet shows how Ben did it.
Those files were contributed by Mike DeLosier (https://www.youtube.com/channel/UCZRfHH6tdS9Q0YVTPkMHyew)