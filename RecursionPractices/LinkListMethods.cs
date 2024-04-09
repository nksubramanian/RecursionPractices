using System;
using System.Collections.Generic;
using System.Diagnostics;
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


        public static void RotateLinkList(ref Link link, int count)
        {
            if (count == 0)
                return;
            else
            {
                do
                {
                    Link x = RemoveFirst(ref link);
                    InsertAtEnd(ref link, x);
                    count--;


                } while (count!=0);

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

        public static Link GetElement(this Link link, int num)
        {
            if(num==1)
                return link;
            Link ptr = link;
            do
            {
                ptr = ptr._next;
            } while (--num > 1);

            return ptr;
        }

        public static Link GetMiddleElement(this Link link)
        {
            int count = link.GetCount();
            double halfCount = (double)count / 2;

            return link.GetElement((int)Math.Ceiling(halfCount));

        }

        public static void InsertAtStart(ref Link link, Link newStart)
        {
            newStart._next = link;
            link = newStart;

        }

        public static void InsertAtEnd(ref Link link, Link newEnd)
        {
            Link ptr = link;
            while(ptr._next!=null)
            {
                ptr = ptr._next;
            }
            ptr._next = newEnd;
        }

        public static Link RemoveFirst(ref Link link)
        {
            Link first = link;
            Link newHead = first._next;
            first._next = null;
            link = newHead;
            return first;

        }


        public static void Reverse(ref Link link)
        {
            Link res = null;
            while (link!=null)
            {
                var x = RemoveFirst(ref link);
                InsertAtStart(ref res, x);
            }
            link = res;
        }

        public static Link dd(this Link link)
        {
            Link first = link;
            while (first._next!=null)
            {
                Link second = first._next;
                Link third = second._next;
                second._next = first;
                first._next = third;
            }
            return first;
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


        public static int GetCount(this Link link)
        {
            int count = 0;
            Link ptr = link;
            while(ptr!=null)
            {
                count++;
                ptr = ptr._next;
            }
            return count;
            
        }

    }
}
