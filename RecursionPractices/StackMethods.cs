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

        public static List<int> NextGreaterElement(List<int> numbers)
        {
            List<int> nextGreaterElements = new List<int>();
            StackList orderedStack = new StackList(new List<int>());
            for (int i = numbers.Count-1; i >=0 ; i--) 
            {
                if(orderedStack.isEmpty())
                {
                    orderedStack.push(numbers[i]);
                    nextGreaterElements.Insert(0,-1);
                }
                else
                {
                    while(true)
                    {
                        if(orderedStack.isEmpty())
                        {
                            nextGreaterElements.Insert(0, -1);
                            break;
                        }
                        int popValue = orderedStack.pop();
                        if (popValue > numbers[i])
                        {
                            nextGreaterElements.Insert(0, popValue);
                            orderedStack.push(popValue);
                            orderedStack.push(numbers[i]);
                            break;
                        }
                    }
                }
                
            
            }
            return nextGreaterElements;
        }

    }
}
