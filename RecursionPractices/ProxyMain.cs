﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractices
{
    public static class ProxyMain
    {

        public static void linkmain()
        {
            Link link = new Link(10);
            link.InsertAtEnd(20);
            link.InsertAtEnd(30);
            link.InsertAtEnd(40);
            link.InsertAtEnd(50);
            link.InsertAtEnd(60);
            //LinkListMethods.InsertAtStart(ref link, 1);
            link.Print();
            Console.WriteLine("******************************************");

            //LinkListMethods.Reverse(ref link);
            LinkListMethods.RotateLinkList(ref link, 4);
            link.Print();
        }


        public static void main()
        {
            int count = 3;
            var indices = Enumerable.Range(0, count);
            var exchangePairs = indices.Select(i => (i, indices.Last() - i)).Take(count / 2).ToList();
            var nos = new List<int> { 2, 3, 6, 7 };
            List<List<int>> result1 = new List<List<int>>();
            SumSubsequences.GetSubSequences(nos, 7, ref result1);
            List<List<int>> result = new List<List<int>>();
            result.Add(new List<int>());

            (int, int) acc = (1, 1);
            var g = Enumerable.Range(0, 5).Aggregate(acc, (acc, x) => {
                var temp = acc;
                acc.Item1 = temp.Item2;
                acc.Item2 = temp.Item2 + temp.Item1;
                return acc;
            }).ToTuple();

            List<string> strings = new List<string> { "a", "b", "c" };
            List<string> accu = new List<string>();
            List<int> numsx = new List<int> { 2, 3, 5, 6, 8, 10 };
            List<List<int>> accumulator = new List<List<int>>();
            QueueMethods.GenerateSubSeq(numsx, 10, ref accumulator);
            var hhhh = QueueMethods.GenerateSubSeq(numsx, 10);
            QueueMethods.GenerateSubStrings(strings, ref accu);

            List<(int, int)> exPairs = new List<(int, int)>();
            var hh = QueueMethods.GenerateSubStrings(strings);
            var gh = QueueMethods.GetExchangePairs(10, ref exPairs, 0);
            var h = QueueMethods.GetExchangePairs(10, 0);
            Console.WriteLine("Hello, World!");
            List<string> characters = new List<string> { "a", "b", "c", "d", "e" };
            var permutations = Permutations.GeneratePermutations(characters);
            bool x = Permutations.ValidateDerangement(characters, "adacb");
            var permutationss = Permutations.GenerateDerangements(characters);
            var permutationsx = Permutations.GenerateNPermutations(characters, 2);
            List<int> numbers1 = Enumerable.Range(1, 2).ToList();
            List<int> numbers2 = Enumerable.Range(4, 10).ToList();
            Func<(bool, int)> numbers1Iter = Permutations.GetIterator(numbers1);
            Func<(bool, int)> numbers2Iter = Permutations.GetIterator(numbers2);

            int hsafd = QueueMethods.GetFactorial(3);
            var number1 = numbers1Iter();
            var number2 = numbers2Iter();
            List<int> sortedList = new List<int>();
            while (true)
            {
                if (number1.Item1 == false && number2.Item1 == false)
                    break;
                else if (number1.Item1 == true && number2.Item1 == true)
                {
                    if (number2.Item2 == number1.Item2)
                    {
                        sortedList.Add(number2.Item2);
                        sortedList.Add(number1.Item2);
                        number1 = numbers1Iter();
                        number2 = numbers2Iter();

                    }
                    else if (number2.Item2 < number1.Item2)
                    {
                        sortedList.Add(number2.Item2);
                        number2 = numbers2Iter();

                    }
                    else
                    {
                        sortedList.Add(number1.Item2);
                        number1 = numbers1Iter();
                    }
                }
                else if (number1.Item1 == true)
                {
                    sortedList.Add(number1.Item2);
                    number1 = numbers1Iter();
                }
                else
                {
                    sortedList.Add(number2.Item2);
                    number2 = numbers2Iter();
                }

            }

            List<int> nums = new List<int>();

            StackList stack = new StackList(nums);
            stack.push(1);
            stack.push(2);
            stack.push(49);
            stack.push(50);
            StackMethods.SortInsert(stack, 3);
            var a = stack.pop();
            var b = stack.pop();
            var c = stack.pop();
            var d = stack.pop();
            var e = stack.pop();

            List<int> numbers = new List<int> { 1, 2, 3, 4 };
            var noss = StackMethods.NextGreaterElement(numbers);
            QueueList queue = new QueueList();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            QueueMethods.PrintList(numbers);

            var gssfa = QueueMethods.getNNumberSum(10);

            Dictionary<string, List<string>> children = new Dictionary<string, List<string>>();
            children.Add("a", new List<string> { "b" });
            children.Add("b", new List<string> { "c", "d" });
            children.Add("c", new List<string>());
            children.Add("d", new List<string> { "e", "f" });
            children.Add("e", new List<string>());
            children.Add("f", new List<string>());


            Dictionary<int, List<int>> numchildren = new Dictionary<int, List<int>>();
            numchildren.Add(1, new List<int> { 2 });
            numchildren.Add(2, new List<int> { 3, 4 });
            numchildren.Add(3, new List<int>());
            numchildren.Add(4, new List<int> { 5, 6 });
            numchildren.Add(5, new List<int>());
            numchildren.Add(6, new List<int>());

            var gg = QueueMethods.traverseDepth("a", children);
            var shh = QueueMethods.traverseBreadth(1, numchildren);
            QueueMethods.reverse(queue);
            string name = QueueMethods.PrintElements(queue);
            int f = queue.Dequeue();
            int f1 = queue.Dequeue();
            int g1 = queue.Dequeue();
            int hhh = 0;
        }

    }
}
