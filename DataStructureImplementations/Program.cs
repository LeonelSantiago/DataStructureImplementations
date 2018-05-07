using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureImplementations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add First:");
            var myList1 = new LinkedList<int>();

            myList1.AddFirst(4);
            myList1.AddFirst(10);
            myList1.AddFirst(25);

            ReverseLinkedList(myList1);

            Console.ReadLine();
        }

        public static void ReverseLinkedList(LinkedList<int> linkedList)
        {
            // ------------------------------------------------------------
            // Create a new linked list and add all items of given 
            // linked list to the copy linked list in reverse order
            // ------------------------------------------------------------

            LinkedList<int> copyList = new LinkedList<int>();

            // ------------------------------------------------------------
            // Start from the latest node
            // ------------------------------------------------------------

            LinkedListNode<int> start = linkedList.First;

            // ------------------------------------------------------------
            // Traverse until the first node is found
            // ------------------------------------------------------------

            while (start != null)
            {
                // ------------------------------------------------------------
                // Add item to the new link list
                // ------------------------------------------------------------

                copyList.AddFirst(start.Value);

                start = start.Previous;
                Console.WriteLine(copyList.First);
            }

            //linkedList = copyList;

            // ------------------------------------------------------------
            // That's it!
            // ------------------------------------------------------------
        }
    }
}
