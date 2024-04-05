using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractices
{
    public class StackList
    {

        private List<int> _list;

        public StackList(List<int> numbers) 
        { 
            _list = numbers;
        
        }
        
        public int pop()
        {
            int value = _list[0];
            _list.RemoveAt(0);
            return value;
        }

        public void push(int val)
        {
            _list.Insert(0, val);
        }

        public bool isEmpty() 
        { 
            return (_list.Count == 0);    
        
        }

        public int peek()
        {
            return _list[0];    
        }




    }
}
