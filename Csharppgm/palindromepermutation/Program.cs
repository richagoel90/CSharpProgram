using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindromepermutation
{
    class Program
    {
        static int Main(string[] args)
        {
            int oddcount = 0;
            Console.WriteLine("Enter the input String");
            String input = Console.ReadLine();
            while(String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Stirng is not correct.Please enter correct string");
                input=Console.ReadLine();
            }
            String ordererdinput = String.Concat(input.OrderBy(c => c));
            
            int[] count = new int[input.Length] ;   
            int j = 0;
            count[j] = 1;
            for (int i=0;i<input.Length-1;i++)
            {
                if(ordererdinput[i]==ordererdinput[i+1])
                {
                    count[j]++;
                }
                else
                {
                    j++;
                    count[j] = 1;
                }
            }
            for(int i=0;i<count.Length;i++)
            {
                if(count[i]%2 !=0)
                {
                    oddcount++;
                }
                if(oddcount>1)
                {
                    Console.WriteLine("Input string permutations are not having palindrome");
                    return 0;
                }
            }
            Console.WriteLine("Input string permutations are having palindrome");
            return 0;
            
        }
    }
}

