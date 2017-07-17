using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Link
    {
        public Link Prev { get; set; }

        public Link Next { get; set; }

        public object Data { get; set; }
    }
}
