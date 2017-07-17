using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class DoublyLinkedList : ILinkedList
    {
        private int length = 0;

        public Link Head { get; set; }

        public Link Tail { get; set; }

        public Link Middle
        {
            get
            {
                return getMiddle();
            }
        }

        public int Length
        {
            get
            {
                return length;
            }
        }

        public DoublyLinkedList()
        {
            Head = new Link();
            Tail = Head;
        }

        public void AddToEnd(object data)
        {
            Link link = new Link()
            {
                Data = data
            };

            // If empty
            if(Tail == Head)
            {                
                Head.Next = link;
                Tail = link;
            }
            else
            {
                // If the tail 'prev' is null, it's the first node. Otherwise set 'prev' to current tail            
                link.Prev = Tail.Prev == null ? null : Tail;

                // Set current tail's next to new link
                Tail.Next = link;

                // Reset tail to new link
                Tail = Tail.Next;
            }            

            length++;
        }

        public void AddToStart(object data)
        {
            // Create new link with 'prev' set to NULL (don't initialize)
            Link link = new Link()
            {
                Data = data,
                Next = Head.Next                
            };

            // Is there a link after head?
            if(Head.Next != null)
            {
                // Set its previous link to null
                Head.Next.Prev = link;
            }

            // Set Head's next to the new link
            Head.Next = link;            

            length++;
        }

        public void RemoveFromEnd()
        {
            // Remove last link if it's not the head
            if(Tail != Head)
            {                
                // Reset Tail to the previous link
                Tail = Tail.Prev;
                Tail.Next = null;

                length--;
            }
        }

        public void RemoveFromStart()
        {
            // Is there a link to remove?
            if(Head.Next != null)
            {
                // Is there more than one link?
                if(Head.Next.Next != null)
                {
                    // Set second link's previous to null.
                    Head.Next.Next.Prev = null;

                    // Set head's next to the second link
                    Head.Next = Head.Next.Next;
                }
                else
                {
                    // Only one node, remove next from head
                    Head.Next = null;
                }

                length--;
            }
        }

        private Link getMiddle()
        {
            Link slow = Head;
            Link fast = Head;

            // Each time, fast skips by two. By skipping two links, when the 'fast' link terminates, 'slow' is at the half-way (middle) point.
            while (fast != null && fast.Next != null)
            {
                // Grab the current fast item + two links down
                fast = fast.Next.Next;

                // Grab the next item
                slow = slow.Next;
            }

            return slow;
        }
    }
}
