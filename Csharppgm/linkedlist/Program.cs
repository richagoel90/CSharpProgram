using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    class node
    {
        public string data { get; private set; }
        public node next;
        public node(string data)
        {
            this.data = data;
            this.next = null;
        }
    }
    class linkedlist
    {
        node head;
        public linkedlist()
        {
            this.head = null;
        }
        public int Addition()
        {
            Console.WriteLine("Enter the 1st node");
            string node_value = "";
            node_value = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(node_value))
            {
                Console.WriteLine("Enter correct input node");
                node_value = Console.ReadLine();
            }
            node addnode = new node(node_value);
            if (this.head == null)
            {
                head = addnode;
            }
            else
            {
                node tempNode = head;
                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }
                tempNode.next = addnode;
            }
            return 0;
        }
        public int deletionnode()
        {
            Console.WriteLine("Enter the node to be deleted:");
            string nodevalue = "";
            nodevalue = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(nodevalue))
            {
                Console.WriteLine("Enter correct input node");
                nodevalue = Console.ReadLine();
            }
            if(this.head==null)
            {
                Console.WriteLine("List is empty");
                return 0;
            }
            else if(this.head.data==nodevalue)
            {
                head = head.next;
            }
            else
            {
                node tempNode = head;
                while(tempNode.next!=null && tempNode.next.data!=nodevalue)
                {
                    tempNode = tempNode.next;
                }
                if(tempNode.next==null)
                {
                    Console.WriteLine("node is not present in the list");
                    return 0;
                }
                else
                {
                    tempNode.next = tempNode.next.next;
                    return 0;
                }
            }
            return 0;
        }
        public int Selection()
        {
            int count = 1;
            string nodevalue="";
            Console.WriteLine("Enter the node to select:");
            nodevalue = Console.ReadLine();
            while (String.IsNullOrWhiteSpace(nodevalue))
            {
                Console.WriteLine("Enter correct input node");
                nodevalue = Console.ReadLine();
            }
            if (this.head==null)
            {
                Console.WriteLine("List is empty");
                return 0;
            }
            else
            {
                node tempNode = head;
                while(tempNode!=null && tempNode.data!=nodevalue)
                {
                    tempNode = tempNode.next;
                    count++;
                }
                if(tempNode==null)
                {
                    Console.WriteLine("Node is not present in the list");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Node {0} is present in the list at {1} position",nodevalue,count);
                    return 0;
                }
            }
            return 0;
        }
        public int Traverse()
        {
            if(this.head==null)
            {
                Console.WriteLine("List is empty");
                return 0;
            }
            else
            {
                node tempNode = this.head;
                while(tempNode!=null)
                {
                    Console.Write("{0} =>",tempNode.data);
                    tempNode = tempNode.next;
                }
                Console.WriteLine("");
            }
            return 0;
        }
    }
    
    class Program
    {
        static int Main(string[] args)
        {
            int option=0;
            linkedlist llist = new linkedlist();
            while(true)
            {
                Console.WriteLine("Enter your option for linked list:");
                Console.WriteLine("Addition-1:");
                Console.WriteLine("Deletion-2:");
                Console.WriteLine("Selection-3:");
                Console.WriteLine("Traverse-4:");
                Console.WriteLine("Quit-5:");
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                switch (option)
                {
                    case 1: llist.Addition();
                            llist.Traverse();
                            break;
                    case 2: llist.deletionnode();
                            llist.Traverse();
                            break;
                    case 3: llist.Selection();
                            llist.Traverse();
                            break;
                    case 4: llist.Traverse();
                            llist.Traverse();
                            break;
                    case 5: return 0;
                    default: Console.WriteLine("not a valid option");
                            break;
                }
            }
            

        }
    }
}
