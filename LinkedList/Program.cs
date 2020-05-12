using System;

namespace LinkedListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList myLinkedList = new MyLinkedList();

            myLinkedList.AddToStart(new MyNode("Number 1"));
            myLinkedList.AddToEnd(new MyNode("Number 2"));
            myLinkedList.AddToEnd(new MyNode("Number 3"));

            Console.WriteLine(myLinkedList.ToString());
            Console.ReadLine();

            MyNode n = myLinkedList.GetNodeFromIndex(2);
            Console.WriteLine(n.Content);
            Console.ReadLine();
        }
    }
}
