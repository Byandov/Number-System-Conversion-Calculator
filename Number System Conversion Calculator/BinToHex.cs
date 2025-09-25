using System;
using System.Collections.Generic;
using System.Text;

namespace Number_System_Conversion_Calculator
{
    internal class BinToHex
    {
        string binary;


        public BinToHex()
        {
            this.binary = Console.ReadLine();
        }
        public override string ToString()
        {
            int dec_num = 0;
            double placeholder = 0;
            foreach (char bit in binary.Reverse())
            {
                if (bit == '1')
                {
                    dec_num += (int)Math.Pow(2, placeholder);

                }
                placeholder++;
            }
            string ToHex = "";
            int number = dec_num;
            while (number > 0)
            {
                int digit = number % 16;
                switch (digit)
                {
                    case 10: ToHex = "A" + ToHex; break;
                    case 11: ToHex = "B" + ToHex; break;
                    case 12: ToHex = "C" + ToHex; break;
                    case 13: ToHex = "D" + ToHex; break;
                    case 14: ToHex = "E" + ToHex; break;
                    case 15: ToHex = "F" + ToHex; break;
                    default: ToHex = digit.ToString() + ToHex; break;
                }
                number /= 16;
            }
            return $"{ToHex}";


        }
    }
}
