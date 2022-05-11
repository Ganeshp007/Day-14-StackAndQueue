// See https://aka.ms/new-console-template for more information

using Day_14_StackAndQueue;
Console.WriteLine("----- Stack Using LinkedList -----");
LinkedListStackOps linkedListStackOps = new LinkedListStackOps();
linkedListStackOps.Push(70);
linkedListStackOps.Push(30);
linkedListStackOps.Push(56);
Console.WriteLine("\n>> Peek and Pop Task : \n");
linkedListStackOps.Peek();
linkedListStackOps.Pop();
Console.WriteLine("\n>> Stack Before EmptyStack Task : \n");
linkedListStackOps.Display();
linkedListStackOps.IsEmpty();
Console.WriteLine("\n>> Stack After EmptyStack Task : \n");
linkedListStackOps.Display();