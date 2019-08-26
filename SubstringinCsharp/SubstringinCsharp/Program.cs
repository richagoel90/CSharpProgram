using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringinCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            String mainString, subString;
            Console.WriteLine("Enter 1st string:");
            mainString = Console.ReadLine();
            Console.WriteLine("Enter 2nd string:");
            subString = Console.ReadLine();
            if(subString.Length>mainString.Length)
            {
                Console.WriteLine($"{subString} is not substring of {mainString} string");
            }
            else
            {
                int i = 0, j = 0,match=0;
                while(subString.Length<=(mainString.Length-i)  && j<subString.Length)
                {
                    if(mainString[i+j]==subString[j])
                    {
                        match = i + 1;
                        j++;
                    }
                    else
                    {
                        i++;j = 0;
                        match = 0;
                    }
                }
                if(match==0)
                {
                    Console.WriteLine($"{subString} is not substring of {mainString} string");
                }
                else
                {
                    Console.WriteLine($"{subString} is substring of {mainString} string at position {match}");
                }
            }
        }
    }
}
