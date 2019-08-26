using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseBitsOfNumber
{
    class Reverse
    {
        public void bitsPrint(uint number)
        {
            Console.WriteLine();
            uint mask1 = 1;
            for (int i = 0; i < 32; i++)
            {
                if ((number & mask1) == 0)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write("1");
                }
                mask1 <<= 1;
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            uint number;
            uint mask1 = 1, mask2=0;
            Console.WriteLine("Enter the number:");
            number = uint.Parse(Console.ReadLine());
            mask2 = mask1 << 31;
            Reverse r = new Reverse();
            r.bitsPrint(number);
            for (int i = 0; i < 16; i++)
            {
                if (((number & mask1) == 0) && ((number & mask2) != 0))
                {
                    number |= mask1;
                    number &= (~mask2);

                }
                else if (((number & mask1) != 0) && ((number & mask2) == 0))
                {
                    number |= mask2;
                    number &= (~mask1);

                }
                mask1 <<= 1;
                mask2 >>= 1;
            }
            Console.WriteLine($"\nReversed number is:{number}");
            r.bitsPrint(number);

        }
    }
}
