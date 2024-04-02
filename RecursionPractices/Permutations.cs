using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractices
{
    public static class Permutations
    {
        public static List<string> GeneratePermutations(List<string> characters)
        {
            List<string> permutations = new List<string>();
            permutations.Add(string.Empty);
            for (int i = 0; i < characters.Count; i++)
            {
                string node = characters[i].ToString();
                List<string> remainingElements = characters.Where((item, index) => index != i).ToList();
                var permsfornode = GeneratePermutations(remainingElements);
                var x = permsfornode.Select(perm => node+perm).ToList();
                permutations = permutations.Concat(x).ToList();

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
