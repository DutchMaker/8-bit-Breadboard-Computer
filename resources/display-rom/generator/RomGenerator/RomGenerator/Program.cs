using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomGenerator
{
    using System.IO;

    class Program
    {
        const int RomSize = 8192; // 8k x 8 bit rom (CAT28C64 EEPROM)

        private static byte[] data = new byte[RomSize];

        private static byte[] digits = { 0xEE, 0x28, 0xDA, 0x7A, 0x3C, 0x76, 0xF6, 0x2A, 0xFE, 0x7E };

        static void Main(string[] args)
        {
            // Fill data with zeros
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = 0;
            }
            
            for (int i = 0; i < 256; i++)
            {
                byte b = (byte)i;
                int address = b << 2;

                Console.Write("Address: ");
                Console.WriteLine(address);
                
                int ones_place = b % 10;
                int tens_place = (b / 10) % 10;
                int hundreds_place = (b / 100) % 10;

                data[address] = digits[ones_place];

                if (tens_place > 0 || (tens_place == 0 && hundreds_place > 0))
                {
                    data[address + 1] = digits[tens_place];
                }

                if (hundreds_place > 0)
                {
                    data[address + 2] = digits[hundreds_place];
                }

                Console.WriteLine(ones_place);
                Console.WriteLine(tens_place);
                Console.WriteLine(hundreds_place);

                

            // 1: 624
            // 2: 625
            // 3: 626

            // Ones place
            //b % 10
            }

            try
            {
                using (var fs = new FileStream("rom.bin", FileMode.Create, FileAccess.Write))
                {
                    fs.Write(data, 0, data.Length);
                    Console.WriteLine("File written");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
            }

            Console.ReadLine();
        }
    }
}
