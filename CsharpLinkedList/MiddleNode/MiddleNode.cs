using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Node;
namespace MiddleNode
{
    public class DerivedLinkedList<T> : Linkedlist<T> 
    {
        public DerivedLinkedList()
        {
            Console.WriteLine("Derived constructor");
        }
        public void computeMiddleNode()
        {
            Node<T> temp1 = base.head, temp2 = this.head;
            while(temp2.next!=null && temp2.next.next!=null )
            {
                temp1 = temp1.next;
                temp2 = temp2.next.next;
            }
            Console.WriteLine($"\nMiddle Node of the list :{temp1.data}");
        }
    }
    class MiddleNode
    {
        static void Main(string[] args)
        {
            DerivedLinkedList<int> Dlist = new DerivedLinkedList<int>();
            int size = 0;
            int nodevalue = 0;
            int n = 0;
            
            Sizecheck:
            try
            {
                Console.WriteLine("Enter the no. of nodes of Linked list:");
                size = int.Parse(Console.ReadLine());
                while (size <= 0)
                {
                    Console.WriteLine("Enter valid size:");
                    size = int.Parse(Console.ReadLine());
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Enter the correct size:");
                goto Sizecheck;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the integer node value:");
                nodevalue:
                try
                {
                    nodevalue = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                    goto nodevalue;
                }
                Dlist.node_Addition(nodevalue);

            }
            Dlist.node_Traverse();
            Dlist.computeMiddleNode();
        }
    }
}
