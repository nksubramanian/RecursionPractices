using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractices
{
    public static class DoublyLinkMethods
    {

        public static void InsertAtStart(ref DoublyLink doublyLink, DoublyLink node)
        {
            node.next = doublyLink;
            doublyLink.prev = node;
            doublyLink = node;
        }

        public static void Print(this DoublyLink doublyLink)
        {
            DoublyLink ptr = doublyLink;
            do
            {
                Console.WriteLine(ptr.value);
                ptr = ptr.next;
            } while (ptr != null);

        }

        public static DoublyLink RemoveAtStart(ref DoublyLink doublyLink)
        {
            DoublyLink temp = doublyLink;
            DoublyLink second = doublyLink.next;
            second.prev = null;
            temp.next = null;
            doublyLink = second;
            return temp;
        }

    }
}
