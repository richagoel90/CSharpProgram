using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Node;

namespace MergeSortedList
{
    public class DerivedLinkedlist<T>:Linkedlist<T>
    {
        public void Compute3rdSortedList(DerivedLinkedlist<int> l1, DerivedLinkedlist<int> l2)
        {
            Node<int> temp1 = l1.head, temp2 = l2.head, l3 = null, temp;
            if (temp1 == null)
            {
                l3 = temp2;
            }
            else if (temp2 == null)
            {
                l3 = temp1;
            }
            else
            {
                if (temp1.data < temp2.data)
                {
                    temp = temp1;
                    temp1 = temp1.next;
                }
                else
                {
                    temp = temp2;
                    temp2 = temp2.next;
                }
                l3 = temp;
                while (temp1 != null && temp2 != null)
                {
                    if (temp1.data < temp2.data)
                    {
                        temp.next = temp1;
                        temp1 = temp1.next;
                    }
                    else
                    {
                        temp.next = temp2;
                        temp2 = temp2.next;
                    }
                    temp = temp.next;
                }
                if (temp1 != null)
                {
                    temp.next = temp1;
                }
                if (temp2 != null)
                {
                    temp.next = temp2;
                }

            }
            Console.WriteLine("Sorted list :");
            while (l3 != null)
            {
                Console.Write($"{l3.data}->");
                l3 = l3.next;
            }
        }

    }
    class MergeSortedList
    {
        static void Main(string[] args)
        {
            List<DerivedLinkedlist<int>> list = new List<DerivedLinkedlist<int>>();
            int size, nodevalue;
            for (int i = 0; i < 2; i++)
            {
                size = 0;
                nodevalue = 0;
                DerivedLinkedlist<int> llist = new DerivedLinkedlist<int>();

                Sizecheck:
                try
                {
                    Console.WriteLine($"Enter the no. of nodes of Linked list {i + 1}:");
                    size = int.Parse(Console.ReadLine());
                    while (size < 0)
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
                for (int j = 0; j < size; j++)
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
                    llist.node_Addition(nodevalue);
                }
                list.Add(llist);


            }
            DerivedLinkedlist<int> dlist = new DerivedLinkedlist<int>();
            dlist.Compute3rdSortedList(list[0], list[1]);
        }
    }
}
