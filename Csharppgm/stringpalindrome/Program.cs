using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringpalindrome
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Enter the string to check it is palindrome or not:");
            String palindromestring=Console.ReadLine();
            if(palindromestring=="")
            {
                Console.WriteLine("Entered string is blank.Please enter valid string");
                palindromestring=Console.ReadLine();
            }
            int length = palindromestring.Length;
            int i = 0, j = length-1;
            while(i <=length/2 && j >= length/2)
            {
                if(palindromestring[i]!=palindromestring[j])
                {
                    Console.WriteLine("String is not palindrome");

                    return 0;
                }
                i++;
                j--;
            }
            Console.WriteLine("String is palindrome");
            return 0;
        }
    }
    }
