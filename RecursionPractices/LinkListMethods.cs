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


        public static void PrinttheCount(this Link link,ref int backcount, ref int count)
        {
            if (link._next != null)
            {
                count++;
                link._next.PrinttheCount(ref backcount, ref count);
                backcount--;
                Console.WriteLine(backcount + " " + count);

            }
            else
            {
                backcount = count;
                Console.WriteLine(backcount + " " + count);
            }

        }

    }
}
