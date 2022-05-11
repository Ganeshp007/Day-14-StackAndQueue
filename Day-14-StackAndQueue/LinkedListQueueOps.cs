using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_StackAndQueue
{
    internal class LinkedListQueueOps
    {


        Node head = null;

        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
                head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;

            }
            Console.WriteLine("> {0} inserted into Queue...", node.data);

        }


        internal void DequeueAll()
        {
            while(head != null)
            {
                head = head.next;
            }
                
            Console.WriteLine("\n> Dequeue Operaton Successfull...");
           
        }

        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("\n>> Queue is empty...");
                return;

            }

            Console.Write("\n>> Queue :- {");
            
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }

            Console.WriteLine("}");


        }





    }
}
