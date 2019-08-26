using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionSolution
{
    class Stacknew
    {
        List<char> stack;
        int count;
        public int size;

        public Stacknew()
        {
            stack = new List<char>();
        }

        void calculateCount()
        {
            count = 0;
            foreach(char var in stack)
            {
                count++;
            }
        }
        public int isEmpty()
        {
            calculateCount();
            if (count < 1)
            {
                Console.WriteLine("stack is empty");
                return -1;
            }
            return 0;
        }
        public int isFull()
        {
            calculateCount();
            if (count == size)
            {
                Console.WriteLine("List is full");
                return -1;
            }
            return 0;
        }
        public void push(char value)
        {
            stack.Add(value);
        }
        public void pop()
        {
            calculateCount();
            stack.RemoveAt(count - 1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stacknew stack = new Stacknew();
            Console.WriteLine("Enter the size of stack:");
            stack.size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the expression to check it is balanced or not: ");
            string expression = Console.ReadLine();
            int returnvalue = 0;
            for(int i=0;i<expression.Length;i++)
            {
                if(expression[i]=='(')
                {
                    returnvalue=stack.isFull();
                    if(returnvalue==-1)
                    {
                        Console.WriteLine("Experssion is unbalanced");
                        return;
                    }
                    stack.push(expression[i]);
                }
                else if(expression[i] == ')')
                {
                    returnvalue = stack.isEmpty();
                    if(returnvalue==-1)
                    {
                        Console.WriteLine("Experssion is unbalanced");
                        return;
                    }
                    stack.pop();
                }

            }
            if(stack.isEmpty()==-1)
            {
                Console.WriteLine("Expression is balanced");
            }
            else
            {
                Console.WriteLine("Experssion is unbalanced");
            }
        }
    }
}
