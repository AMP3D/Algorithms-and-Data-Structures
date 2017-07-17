using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ILinkedList singlyLinkedList = new SinglyLinkedList();
            ILinkedList doublyLinkedList = new DoublyLinkedList();

            Console.WriteLine("Singly Linked List Output: ");
            Display(singlyLinkedList);            

            Console.WriteLine("Doubly Linked List Output: ");
            Display(doublyLinkedList);

            Console.ReadKey();
        }

        static void Display(ILinkedList linkedList)
        {
            Console.WriteLine("-----------------------------------");

            linkedList.AddToEnd(3); // 3
            linkedList.AddToStart(2); // 2, 3
            linkedList.AddToEnd(4); // 2, 3, 4  
            linkedList.AddToEnd(5); // 2, 3, 4, 5
            linkedList.AddToStart(1); // 1, 2, 3, 4, 5
            linkedList.AddToStart(0); // 0, 1, 2, 3, 4, 5

            // Should remove '0'
            linkedList.RemoveFromStart();

            // Should remove '5'
            linkedList.RemoveFromEnd();
            
            Console.WriteLine("List Length: {0}", linkedList.Length);
            Console.WriteLine("Middle Data: {0}", linkedList.Middle.Data);

            var current = linkedList.Head.Next;
            while (current != null)
            {
                // Should display 1, 2, 3, 4
                Console.WriteLine(current.Data);
                current = current.Next;
            }            

            Console.WriteLine();
        }
    }
}
