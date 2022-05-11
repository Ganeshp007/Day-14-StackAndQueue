// See https://aka.ms/new-console-template for more information

using Day_14_StackAndQueue;

Console.WriteLine("----- Queue Using LinkedList -----\n");

LinkedListQueueOps linkedListQueue = new LinkedListQueueOps();
linkedListQueue.Enqueue(56);
linkedListQueue.Enqueue(30);
linkedListQueue.Enqueue(70);
linkedListQueue.Display();
