using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList sll = new SingleLinkedList();
            sll.AddToTail(1);
            sll.AddToTail(2);
            sll.AddToTail(3);
            //sll.ShowList();
            //Node findNode = sll.FindByValue(2);
            //Console.WriteLine(findNode.data);
            sll.InsertAfter(new Node(3), 4);
            sll.ShowList();
        }
    }
}
