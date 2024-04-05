using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractices
{
    public static class StackMethods
    {
        public static void InsertAtBottom(StackList stack, int val)
        {
            if (stack.isEmpty())
            {
                stack.push(val);
            }
            else
            {
                int num = stack.pop();
                InsertAtBottom(stack, val);
                stack.push(num);

            }
        }

        public static void SortInsert(StackList stack, int val)
        {
            if (stack.isEmpty())
            {
                stack.push(val);
                return;
            }
            int popValue = stack.pop();
            if (popValue <= val) 
            {
                stack.push(popValue);
                stack.push(val);
                return;
            }
            else
            {
                SortInsert(stack, val);
                stack.push(popValue);
                return;
            }


        }

    }
}
