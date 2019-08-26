using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node
{
    public class Linkedlist<T>
    {
        protected Node<T> head;
        public Linkedlist()
        {
            this.head = null;
            //Console.WriteLine("Linkedlist class constructor");
        }
        public void node_Addition(T nodevalue)
        {
            Node<T> addNode = new Node<T>();
            addNode.data = nodevalue;
            addNode.next = null;
            if (this.head == null)
            {
                this.head = addNode;
            }
            else
            {
                Node<T> tempNode = this.head;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = addNode;
            }
        }
        public void node_Traverse()
        {
            if (this.head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else
            {
                Node<T> tempNode = this.head;
                while (tempNode != null)
                {
                    Console.Write($"{tempNode.data} ->");
                    tempNode = tempNode.next;
                }
            }

        }
        public void computeNthNodefromLast(int n)
        {
            Node<T> temp1 = this.head, temp2 = this.head;
            for (int i = 0; i < n; i++)
            {
                temp2 = temp2.next;
            }
            while (temp2 != null)
            {
                temp1 = temp1.next;
                temp2 = temp2.next;
            }
            Console.WriteLine($"{n} th node from last :{temp1.data}");
        }

    }

}
