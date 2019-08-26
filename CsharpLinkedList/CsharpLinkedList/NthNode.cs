using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Node;

namespace NthNodeFromLast
{
    class NthNode
    {
        static void Main(string[] args)
        {
            int size=0;
            int nodevalue = 0;
            int n = 0;
            Linkedlist<int> llist = new Linkedlist<int>();

            Sizecheck:
            try
            {
                Console.WriteLine("Enter the no. of nodes of Linked list:");
                size = int.Parse(Console.ReadLine());
                while(size<=0)
                {
                    Console.WriteLine("Enter valid size:");
                    size = int.Parse(Console.ReadLine());
                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Enter the correct size:");
                goto Sizecheck;
            }
            for(int i=0;i<size;i++)
            {                
                Console.WriteLine("Enter the integer node value:");
                nodevalue:
                try
                {
                    nodevalue = int.Parse(Console.ReadLine());
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                    goto nodevalue;
                }
                llist.node_Addition(nodevalue);
                
            }
            llist.node_Traverse();
            compute_n:
            try
            {
                Console.WriteLine("\nEnter the number of node to fetch from last: ");
                n = int.Parse(Console.ReadLine());
                while(n<1 || n>size)
                {
                    Console.WriteLine("Enteres value is out of range:");
                    n = int.Parse(Console.ReadLine());

                }
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
                goto compute_n;
            }
            llist.computeNthNodefromLast(n);
        }
    }
}
