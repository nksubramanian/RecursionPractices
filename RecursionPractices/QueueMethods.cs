using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractices
{
    public static class QueueMethods
    {

        public static void reverse(QueueList q)
        {
            if (q.IsEmpty())
                return;
            var a = q.Dequeue();
            reverse(q);
            q.Enqueue(a);


        }
    }
}
