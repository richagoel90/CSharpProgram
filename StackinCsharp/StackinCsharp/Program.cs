using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackinCsharp
{
    class Stack1
    {
        public void push(int value,List<int> list)
        {
                list.Add(value);
            
        }
        public void traverse(List<int> list)
        {
            foreach(int var in list)
            {
                Console.Write($"{var} ->");
            }
        }
        public void pop(int pos,List<int> list)
        {
                list.RemoveAt(pos - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack1 stack = new Stack1();
            Console.WriteLine("Enter teh size of stack");
            int size = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            int option = 0;
            while(true)
            {

                Console.WriteLine("\nSelect the option");
                Console.WriteLine("1 - Push");
                Console.WriteLine("2 - Pop");
                Console.WriteLine("3 - Traverse");
                Console.WriteLine("4 - Quit");
                option = int.Parse(Console.ReadLine());
                int count = 0;
                foreach (int var in list)
                {
                    count++;
                }
                

                switch (option)
                {
                    case 1:
                        if (size <= count)
                        {
                            Console.WriteLine("list is full");
                            break;
                        }
                        Console.WriteLine("Enter node value:");
                        int value = int.Parse(Console.ReadLine());
                        stack.push(value,list);
                        stack.traverse(list);
                        break;
                    case 2:
                        if(count<1)
                        {
                            Console.WriteLine("List is empty");
                            break;
                        }
                        stack.pop(count,list);
                        stack.traverse(list);
                        break;
                    case 3:
                        stack.traverse(list);
                        break;
                    case 4: return;
                }
            }
        }
    }
}
