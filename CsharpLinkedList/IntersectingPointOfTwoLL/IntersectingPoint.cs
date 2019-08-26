using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Node;

namespace IntersectingPointOfTwoLL
{
    class DerivedLinkedlist<T>: Linkedlist<T>
    {
        public void ComputeIntersection(DerivedLinkedlist<T> l1, DerivedLinkedlist<T> l2)
        {
            int size_l1 = 0, size_l2 = 0;
            Node<T> temp_l1=l1.head, temp_l2=l2.head,temp=null;

            while (temp_l1 != null)
            {
                size_l1++;
                temp_l1 = temp_l1.next;
            }
            temp_l1 = l1.head;

            while (temp_l2 != null)
            {
                size_l2++;
                temp_l2 = temp_l2.next;
            }
            temp_l2 = l2.head;

            temp = size_l1 > size_l2 ? temp_l1 : temp_l2;
            
            for(int i=0;i<Math.Abs(size_l1-size_l2);i++)
            {
                    temp = temp.next;
            }
            if (size_l1 > size_l2)
            {
                temp_l1 = temp;
            }
            else
            {
                temp_l2 = temp;
            }
                
            while(temp_l1!=null && !temp_l1.data.Equals(temp_l2.data))
            {
                temp_l1 = temp_l1.next;
                temp_l2 = temp_l2.next;
            }

            if (temp_l1 == null)
            {
                Console.WriteLine("Lists are not intersecting at any point");
            }
            else
            {
                Console.WriteLine($"List intersect at {temp_l1.data}");
            }

        }
            }
    class IntersectingPoint
    {
        static void Main(string[] args)
        {
            List<DerivedLinkedlist<int>> list= new List<DerivedLinkedlist<int>>();
            int size, nodevalue;
            for (int i=0;i<2;i++)
            {
                size = 0;
                nodevalue = 0;
                DerivedLinkedlist<int> llist = new DerivedLinkedlist<int>();
       
                Sizecheck:
                try
                {
                    Console.WriteLine($"Enter the no. of nodes of Linked list {i+1}:");
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
            dlist.ComputeIntersection(list[0], list[1]);
         
        }
    }
}
