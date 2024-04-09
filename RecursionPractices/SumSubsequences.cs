using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractices
{
    public static class SumSubsequences
    {

        public static void GetSubSequences(List<int> numbers, int target, ref List<List<int>> acc, List<int> sequence = null)
        {
            if (sequence == null)
                sequence = new List<int>();
            if (target == 0)
            {
                acc.Add(sequence);  
            }
            else
            {
                if(numbers.Count>0)
                {
                    if (target>=numbers[0])
                    {
                        GetSubSequences(numbers, target - numbers[0], ref acc, sequence.Concat(new List<int> { numbers[0] }).ToList());
                        GetSubSequences(numbers.Skip(1).ToList(), target, ref acc, sequence);
                    }
                }

            }

        }


    }
}
