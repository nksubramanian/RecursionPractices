using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractices
{

    public static class Permutations
    {
        static (int, int) GetIndex(List<int> numbers, int no, int start, int end)
        {
            if (numbers.Count == 0)
                return (-1, -1);
            if (numbers[numbers.Count - 1] <= no)
                return (numbers.Count + 1, numbers.Count + 1);
            if (numbers[0] > no)
                return (-1, -1);
            if (end == start)
                return (end + 1, end + 1);
            if ((end - start == 1) && no >= numbers[end])
                return (end + 1, end + 1);
            if ((end - start == 1) && no < numbers[start])
                return (start - 1, start - 1);
            if ((end - start == 1) && no >= numbers[start] && no < numbers[end])
                return (start + 1, start + 1);
            else
            {
                int newIndex = (end - start) / 2 + start;
                if (numbers[newIndex] <= no)
                    return GetIndex(numbers, no, newIndex, end);
                else
                    return GetIndex(numbers, no, start, newIndex);
            }
        }
        public static List<string> GenerateNPermutations(List<string> characters, int n)
        {
            if(n == 1)
                return characters;  
            List<string> permutations = new List<string>();
            for(int i = 0; i < characters.Count; i++)
            {
                string x = characters[i].ToString();
                var remainingElements = characters.Where((value, index)=>index!=i).ToList();
                var perms = GenerateNPermutations(remainingElements, n - 1);
                foreach(string perm in perms)
                {
                    permutations.Add(x+perm);
                }

            }
            return permutations;    

        }


        public static Func<(bool, T)> GetIterator<T>(List<T> numbers)
        {
            int count = 0; 
            List<T> ints = numbers;
            return () => {
                if (count >= numbers.Count)
                    return (false, default);
                else
                {
                    return (true, ints[count++]);

                }

            };
        }


        public static List<string> GeneratePermutations(List<string> characters)
        {
            List<string> permutations = new List<string>();
            permutations.Add(string.Empty);
            for (int i = 0; i < characters.Count; i++)
            {
                string node = characters[i].ToString();
                var remaningElements = characters.Where((value, index)=>index!=i).ToList();
                var permsfornode = GeneratePermutations(remaningElements);
                permutations = permsfornode.Select(perm => node+perm).Concat(permutations).ToList();
            }
            return permutations;
        }

        public static bool ValidateDerangement(List<string> characters, string derangement)
        {
            return (derangement.Count() > characters.Count) && 
                derangement.Select((c,i) => characters[i] != c.ToString()).Aggregate((acc, i)=>acc && i);
        }

        public static List<string> GenerateDerangements(List<string> characters, List<string> perm = default)
        {
            perm ??= new List<string> { string.Empty };
            if(characters.Count ==0 )
                return perm;
            List<string> permutations = new List<string>();
            for (int i = 0; i < characters.Count; i++)
            {
                List<string> generatedPerm = perm.Select(str => str + characters[i]).ToList();
                List<string> remainingElements = characters.Where((item, index) => index != i).ToList();
                var permutation = GenerateDerangements(remainingElements, generatedPerm);
                permutations = permutations.Concat(permutation).ToList();
            }
            return permutations;
        }


    }
}
