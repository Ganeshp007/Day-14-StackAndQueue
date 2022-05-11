using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_StackAndQueue
{
    internal class LinkedListStackOps
    {

        private Node top;

        internal void Push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("\n>>> {0} pushed to stack...", value);
        }

        public void Display()
        {
            Node temp = this.top;
            Console.WriteLine("\n>>> Stack-1 :- ");
            while (temp != null)
            {
                Console.Write("\t\t| "+temp.data + " |\n");  
                temp = temp.next;
            }
            
        }



    }
}
