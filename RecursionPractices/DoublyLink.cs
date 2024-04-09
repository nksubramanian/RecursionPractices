using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractices
{
    public class DoublyLink
    {
        public DoublyLink prev;
        public DoublyLink next;
        public int value;

        public DoublyLink(int val)
        {
            this.prev = null;
            this.value = val;
            this.next = null;
        }
    }
}
