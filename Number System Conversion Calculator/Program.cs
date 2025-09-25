using System;

namespace Number_System_Conversion_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose data type: 1-bin");
                int Choice = int.Parse(Console.ReadLine());
                if (Choice == 1)
                {
                    Console.WriteLine("Choose data type to convert to:1-bin , 2-octal, 3-dec, 4-hex:");
                    int convertTo = int.Parse(Console.ReadLine());

                    try
                    {
                        if (convertTo == 1)
                        {
                            throw new Exception("Cannot convert binary to binary");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"There was an error: {ex.Message}");
                    }
                    if (convertTo == 2)
                    {
                        Console.WriteLine("Enter number:");
                        BinToOct bintooct = new BinToOct();
                        Console.WriteLine($"Result:{bintooct.ToString()}");
                    }
                    if (convertTo == 3)
                    {
                        Console.WriteLine("Enter number:");
                        BinToDec bintodec = new BinToDec();
                        Console.WriteLine($"Result:{bintodec.ToString()}");
                    }
                    if (convertTo == 4)
                    {
                        Console.WriteLine("Enter number:");
                        BinToHex bintohex = new BinToHex();
                        Console.WriteLine($"Result:{bintohex.ToString()}");

                    }
                }
            }
        }
    }
}
