using System;
using System.Collections.Generic;
using System.Text;

namespace Number_System_Conversion_Calculator
{
    internal class BinToOct
    {
        string binary;
        

        public BinToOct()
        {
            this.binary = Console.ReadLine();
        }
        public override string ToString()
        {
            int dec_num = 0;
            double placeholder = 0;
            foreach (char bit in binary.Reverse())
            {
                if(bit == '1')
                {
                    dec_num += (int)Math.Pow(2, placeholder);
                    
                }
                placeholder++;
            }
            
            string ToOct = "";
            for(;dec_num>0; dec_num /= 8)
            {
                ToOct = (dec_num % 8) + ToOct;
            }
            return $"{ToOct}";
        }
            

    }
}
