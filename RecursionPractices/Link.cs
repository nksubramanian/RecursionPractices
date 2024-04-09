using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractices
{
    public class Link
    {
        public Link _next;
        public int _value;

        public Link(int value)
        {
            _value = value;
            _next = null;
        }


        public void AddNext(Link link)
        {
            _next = link;
        }

    }
}
