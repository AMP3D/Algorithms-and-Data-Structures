namespace LinkedLists
{
    public class SinglyLinkedList : ILinkedList
    {
        private int length = 0;

        public Link Tail { get; set; }

        public Link Head { get; set; }

        public int Length
        {
            get
            {
                return length;
            }    
        }

        public Link Middle
        {
            get
            {
                return getMiddle();
            }
        }

        public SinglyLinkedList()
        {
            Head = new Link();
            Tail = Head;
        }

        public void AddToStart(object data)
        {
            // Create new link and set its next value to the link after head
            Link link = new Link()
            {
                Data = data,
                Next = Head.Next
            };

            // Set head's next to the new link
            Head.Next = link;

            // Increment list length
            length++;
        }

        public void AddToEnd(object data)
        {
            Link link = new Link()
            {
                Data = data
            };

            // If this is the first item
            if(Head == Tail)
            {
                // Append to head, and set tail to item
                Head.Next = link;
                Tail = link;
            }
            else
            {
                // Set tail's next to new link then set tail to new link
                Tail.Next = link;
                Tail = Tail.Next;
            }

            // Increment list length
            length++;
        }

        public void RemoveFromStart()
        {
            // Get the first link
            var next = Head.Next;

            // If the first link exists, use its 'next' value for head's 'next' (skip a link)
            if(next != null)
            {
                Head.Next = next.Next;
                next = null;

                // Reduce list length
                length--;
            }            
        }

        public void RemoveFromEnd()
        {
            // Get the first link
            var next = Head.Next;

            // If only one link, remove it and reset
            if (next.Next == null)
            {
                Head.Next = null;
                Tail = Head;
                length--;
            }
            else
            {
                while (next.Next != null)
                {
                    // Look two links down
                    if (next.Next.Next == null)
                    {
                        next.Next = null;
                        Tail = next;

                        // Reduce list length
                        length--;
                    }
                    else
                    {
                        next = next.Next;
                    }
                }
            }
        }

        private Link getMiddle()
        {            
            Link slow = Head;
            Link fast = Head;

            // Each time, fast skips by two. By skipping two links, when the 'fast' link terminates, 'slow' is at the half-way (middle) point.
            while(fast != null && fast.Next != null)
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