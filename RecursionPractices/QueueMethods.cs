using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
