# 8-bit breadboard computer parts list
If you are following Ben Eater's build of an 8-bit breadboard computer (https://www.youtube.com/playlist?list=PLowKtXNTBypGqImE405J2565dvjafglHU) and are looking for a complete (*1) list of all the parts, then here you go:

**1) The video series is still on-going so the part list is not complete yet. I will update this list every time a new video has been upload.*

**2) The EEPROM programmer (as stand alone product) is optional, you can also build it yourself. Components for this are marked under the EEPROM Programmer module.*

| Part | Amount | Description | Modules | Datasheet |
| --- | --- | --- | --- | --- |
| 22 gauge wire | - | Breadboard wire | All |  |
| 555 timer | 4 |  | Clock, Output | http://www.ti.com/lit/ds/symlink/lm555.pdf |
| 74HC595 | 2 | 8-bit serial-in, parallel-out shift register | EEPROM programmer | http://www.nxp.com/documents/data_sheet/74HC_HCT595.pdf |
| 74LS00 | 1 | Quad NAND gate | RAM | http://www.ti.com/lit/ds/symlink/sn7400.pdf |
| 74LS04 | 3 | Hex inverter | Clock, RAM | http://www.ti.com/lit/ds/symlink/sn74ls04.pdf |
| 74LS08 | 1 | Quad AND gate | Clock | http://www.ti.com/lit/ds/symlink/sn74ls08.pdf |
| 74LS139 | 1 | Dual 2-to-4 line decoder | Output | http://www.ti.com/lit/ds/symlink/sn54ls139a.pdf |
| 74LS157 | 4 | Quad 2-to-1 line data selector | RAM | http://www.ti.com/lit/ds/symlink/54ls157.pdf |
| 74LS161 | 1 | 4-bit synchronous binary counter | Program Counter | http://www.ti.com/lit/ds/symlink/sn74ls161a.pdf |
| 74LS173 | 7 | 4-bit D-type register | Registers, RAM | http://www.ti.com/lit/ds/symlink/sn74173.pdf |
| 74LS189 | 2 | 64-bit RAM | RAM | http://www.ndatasheet.com/datasheet-frame/300/mdownload.php?id=529296 |
| 74LS245 | 6 | Octal bus transceiver | Registers, ALU, RAM, Program Counter | http://www.ti.com/lit/ds/symlink/sn74ls245.pdf |
| 74LS283 | 2 | 4-bit binary full adder | ALU | http://www.ti.com/lit/ds/symlink/sn54s283.pdf |
| 74LS32 | 1 | Quad OR gate | Clock | http://www.ti.com/lit/ds/symlink/sn54ls32.pdf |
| 74LS76  | 1 | Dual JK flip-flop | Output | http://www.ti.com/lit/ds/symlink/sn5476.pdf |
| 74LS86 | 2 | Quad XOR gate | ALU | http://www.ti.com/lit/ds/symlink/sn74ls86a.pdf |
| 7-segment display | 4 | Common cathode 7-segment display | Output |  |
| Arduino Nano | 1 | Microcontroller | EEPROM programmer | https://www.arduino.cc/en/uploads/Main/ArduinoNanoManual23.pdf |
| Breadboard | 16 | 830 tie point solderless breadboard | All |  |
| Capacitor 0.01µF | 6 |  | Clock, RAM, Output |  |
| Capacitor 0.1µF | 2 |  | Clock |  |
| Capacitor 2µF | 2 |  | Clock |  |
| CAT28C16AP | 6 | 16 Kbit CMOS parellel EEPROM | Output, Control Unit | http://www.alldatasheet.com/datasheet-pdf/pdf/57374/CATALYST/CAT28C16AP-20T.html |
| EEPROM programmer (*2) | 1 | Required to program the EEPROM chips | Output, Control Unit | http://www.ebay.com/itm/191816776888 |
| Jumper wires | - | Breadboard jumper wire | All |  |
| LED (blue) | 5 |  | Clock, Instruction Register, RAM |  |
| LED (green) | 5 |  | RAM, Program Counter |  |
| LED (red) | 33 |  | Registers, RAM |  |
| LED (yellow) | 11 |  | Clock, Instruction Register, RAM |  |
| Momentary switch | 1 | Microtivity 6mm tact switch | Clock |  |
| Resistor 100kΩ | 2 |  | Clock, Output |  |
| Resistor 1kΩ | 9 |  | Clock, RAM, Output |  |
| Resistor 1MΩ | 2 |  | Clock |  |
| Resistor 330Ω | 3 |  | Clock |  |
| Toggle switch | 1 | Double-pole toggle switch | Clock | 
