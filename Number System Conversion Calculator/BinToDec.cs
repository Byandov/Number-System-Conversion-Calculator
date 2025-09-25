using System;
using System.Collections.Generic;
using System.Text;

namespace Number_System_Conversion_Calculator
{
    internal class BinToDec
    {
        public string binary;
        private int ToDec;

        public BinToDec()

        {
            this.binary = Console.ReadLine();
        }
        public override string ToString()
        {
            ToDec = 0;
            for (int i = 0; i < binary.Length; i++)
            {
                int bit = binary[binary.Length - 1 - i] - '0';


                ToDec += bit * (int)Math.Pow(2, i);
            }
            return $"{ToDec}";
        }

    }
}
