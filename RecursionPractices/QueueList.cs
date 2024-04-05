using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractices
{
    public class QueueList
    {
        private List<int> _queue;
        public QueueList() 
        { 
            _queue = new List<int>();
        }

        public void Enqueue(int val)
        {
            _queue.Insert(0, val);
        }

        public int Dequeue()
        {
            var count = _queue.Count;
            int val = _queue[count-1];
            _queue.RemoveAt(count-1);
            return val;
        }

        public bool IsEmpty() 
        { 
            return _queue.Count == 0;


        }


    }
}
