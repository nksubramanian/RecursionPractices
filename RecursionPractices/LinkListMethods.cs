using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractices
{
    public static class LinkListMethods
    {
        public static void InsertAtEnd(this Link link, int val)
        {
            if (link._next == null)
                link._next = new Link(val);
            else
            {
                var n = link._next;
                n.InsertAtEnd(val);
            }
        }

        public static void InsertAtStart(ref Link link, int val)
        {
            var  a = new Link(val);
            a._next = link;
            link =a;

        }

        public static void Print(this Link link)
        {
            Console.WriteLine(link._value);
            if (link._next != null)
            {
                link._next.Print();
            }

        }


        public static void PrinttheCount(this Link link, int count = 1)
        {
            if (link._next != null)
            {
                link._next.PrinttheCount(++count);
            }
            else
            {
                Console.WriteLine(count);
            }

        }

    }
}
