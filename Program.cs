using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                UInt64 input = 0;
                while (input <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a number to find its binary counterpart : ");
                    input = Convert.ToUInt64(Console.ReadLine());
                }
                Binarer(input);
            }
            
        }
        public static void Binarer(UInt64 input)
        {
            
            List<int> digits = new List<int>();
            while(!(input == 0))
            {
                UInt64 reminder = input % 2;

                if (reminder == 1)
                {
                    digits.Add(1);
                }
                if (reminder == 0)
                {
                    digits.Add(0);
                }
                input = input / 2;
            }
            digits.Reverse();
            Console.Clear();
            Console.WriteLine("The binary format is");
            foreach (int item in digits)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
