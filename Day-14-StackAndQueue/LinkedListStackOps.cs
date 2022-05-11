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
            Console.WriteLine("> {0} pushed to stack...", value);
        }


        internal void Peek()
        {  
            if (this.top == null)
            {
                Console.WriteLine("\n>> Stack - 1 :-\n\t\t | Stack is Empty |\n");
                return;
            }
            else
            Console.WriteLine("> Peek :- {0} is in the top of the stack ", this.top.data);
        }

        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("\n>> Stack - 1 :- Can not Delete Element\n\t\t | Stack is Empty |\n");
                return;
            }
            Console.WriteLine("> Pop :- Value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }

        internal void IsEmpty()
        {  
            Console.WriteLine("\n----------------------------------\n>> Performing EmptyStack Task :-\n");
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("\n----------------------------------");

        }

        public void Display()
        {
            if(top == null)
            {
                Console.WriteLine("\n >>> Stack - 1 :-\n\t\t  | Stack is Empty |\n");
            }
            else
            {
                Node temp = this.top;
                Console.WriteLine("\n>>> Stack-1 :- ");
                while (temp != null)
                {
                    Console.Write("\t\t| " + temp.data + " |\n");
                    temp = temp.next;
                }

                Console.WriteLine("\n");
            }
            
            
        }



    }
}
