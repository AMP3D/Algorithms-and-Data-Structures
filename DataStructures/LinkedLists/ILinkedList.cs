using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    interface ILinkedList
    {
        void AddToEnd(object data);

        void AddToStart(object data);

        Link Head { get; set; }

        Link Middle { get; }

        int Length { get; }

        Link Tail { get; set; }

        void RemoveFromEnd();

        void RemoveFromStart();
    }
}
