using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace permutationofstring
{
    class permutation
    {
        public void permute(ref string input,int start,int end)
        {
            if (start == end)
            {
                Console.WriteLine(input);
            }
            else
            {
                for(int i=start;i<=end;i++)
                {
                    swap(ref input, i, start);
                    permute(ref input, start + 1, end);
                    swap(ref input, i, start);
                }
                
            }
        }
        public void swap(ref string s,int i,int start)
        {
            char[] temp = new char[s.Length];
            temp = s.ToCharArray();
            temp[i] = s[start];
            temp[start] = s[i];
            s = new string(temp);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string:");
            string input = Console.ReadLine();
            permutation per = new permutation();
            int length = input.Length;
            int start = 0;
            int end = length - 1;
            per.permute(ref input,start,end);
        }
    }
}
