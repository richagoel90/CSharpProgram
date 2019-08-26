using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversebitCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,mask=1;
            Console.Write("Enter the number to reverse bits:");
            number = int.Parse(Console.ReadLine());
            for(int i=0;i<32;i++)
            {
                if((number&mask)==0)
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write("1");
                }
                mask <<= 1;
            }
            mask = 1;
            Console.Write("\n");
            for (int i = 0; i < 32; i++)
            {
                if (((~number)&mask) == 0)
                    
                {
                    Console.Write("0");
                }
                else
                {
                    Console.Write("1");
                }
                mask <<= 1;
            }
            Console.WriteLine(~number);
        }
    }
}
