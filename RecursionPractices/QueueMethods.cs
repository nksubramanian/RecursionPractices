using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
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


        public static string PrintElements(QueueList q)
        {
            if (q.IsEmpty())
                return string.Empty;
            else
            {
                return q.Dequeue().ToString() + " " + PrintElements(q);
            }



        }

        public static List<string> traverseDepth(string node, Dictionary<string, List<string>> tree)
        {
            var Children = tree[node];
            if (Children.Count == 0)
            {
                return new List<string> { node };
            }
            else
            {
                List<string> pathsFromSubtrees = new List<string>();
                foreach (var child in Children)
                {
                    var subTree = traverseDepth(child, tree);
                    pathsFromSubtrees = pathsFromSubtrees.Concat(subTree).ToList();
                }
                return pathsFromSubtrees.Select(x => node + x).ToList();

            }
        }


        public static List<string> traverseBreadth(int node, Dictionary<int, List<int>> tree)
        {
            QueueList queue = new QueueList();
            List<string> paths = new List<string>();
            queue.Enqueue(node);
            while(!queue.IsEmpty())
            {
                var breadth = queue.Dequeue();
                var children = tree[breadth%10];
                if(children.Count == 0)
                {
                    paths.Add(breadth.ToString());
                }
                else
                {
                    foreach (var child in children)
                    {
                        Console.WriteLine(int.Parse(breadth.ToString() + child.ToString()));
                        queue.Enqueue(int.Parse(breadth.ToString() + child.ToString()));
                    }
                }
               
            }
            return paths;

        }

        public static int getNNumberSum(int n, int sum = 0)
        {
            if(n==0)
                return sum;
            else
            {
                sum += n;
                n = n - 1;
                return getNNumberSum(n, sum); 
            }

        }

        public static List<(int, int)> GetExchangePairs(int count, int sPoint = 0)
        {
            List<(int, int)> values = new List<(int, int)> ();
            if(count-1>sPoint)
            {
                values.Add((sPoint, count-1));
                List<(int, int)> subExPairs = GetExchangePairs(count - 1, sPoint + 1);
                return values.Concat(subExPairs).ToList();
            }
            return values;


        }

        public static List<string> GenerateSubStrings(List<string> characters)
        {
            if(characters.Count==0)
                return new List<string> { string.Empty };
            else
            {
                var remainingCharacters = characters.Skip(1).ToList();
                List<string> substrings = GenerateSubStrings(remainingCharacters);
                return substrings.Concat(substrings.Select(substring => characters[0] + substring)).ToList();


            }

        }


        public static List<(int, int)> GetExchangePairs(int count,ref List<(int, int)> exPair, int sPoint = 0)
        {
            if(sPoint<count-1)
            {
                exPair.Add((sPoint, count - 1));
                GetExchangePairs(count - 1, ref exPair, sPoint+1);
                
            }
            return exPair;

        }
        public static void GenerateSubStrings(List<string> characters, ref List<string> acc)
        {
            if (characters.Count > 0)
            {
                acc = acc.Select(x => x + characters[0]).Concat(acc).Append(characters[0]).ToList();
                var remainingCharacters = characters.Skip(1).ToList();
                GenerateSubStrings(remainingCharacters, ref acc);

            }

        }

        public static void GenerateSubSeq(List<int> numbers, int sum,  ref List<List<int>> acc, List<int> seq = null)
        {
            if (seq == null)
            {
                seq = new List<int>();
            }
            if (sum == 0)
            {
                acc.Add(seq);
                return;
            }
            else
            {
                if(numbers.Count>0 && sum > 0)
                {
                    var remainingNos = numbers.Skip(1).ToList();

                    GenerateSubSeq(remainingNos, sum, ref acc, new List<int>(seq));
                    if (numbers[0] <= sum)
                    {
                        List<int> sequences = new List<int>(seq);
                        sequences.Add(numbers[0]);
                        GenerateSubSeq(remainingNos, sum - numbers[0], ref acc, sequences);
                    }

                }

            }
        }

        public static List<List<int>> GenerateSubSeq(List<int> numbers, int sum)
        {

            if (sum == 0)
            {
                List<List<int>> result = new List<List<int>>();
                result.Add(new List<int>());
                return result;
            }
            else
            {
                var res = new List<List<int>>();
                if (numbers.Count > 0)
                {
                    var remainingNos = numbers.Skip(1).ToList();

                    if (sum>= numbers[0])
                    {
                        var x = sum - numbers[0];
                        var lists = GenerateSubSeq(remainingNos, x);
                        foreach ( var list in lists)
                        {
                            res.Add(list.Append(numbers[0]).ToList());
                        }
                        var listss = GenerateSubSeq(remainingNos, sum);
                        return res.Concat(listss).ToList();
                    }
                    return res;

                }

            }
            return new List<List<int>>();
        }



        public static int GetFactorial(int n, int factorial = 1)
        {
            if (n == 1)
                return factorial;
            else
            {
                return GetFactorial(n - 1, factorial * n);
            }
        }

        public static void PrintList(List<int> numbers)
        {
            void print(List<int> numbers, int index=0)
            {
                if(numbers.Count<=index)
                {
                    return;
                }
                Console.WriteLine(numbers[index]);
                print(numbers, index + 1);
                return;
            }

            print(numbers);
        }


    }
}
