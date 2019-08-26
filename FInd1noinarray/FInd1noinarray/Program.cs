using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInd1noinarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the array length:");
            size = int.Parse(Console.ReadLine());
            int result=0;
            for (int i=0;i<size;i++)
            {
                Console.WriteLine("ENter the array element:");
               result^=int.Parse(Console.ReadLine()));
            }
            Console.WriteLine($"one odd number in array:{result}");

        }
    }
}
