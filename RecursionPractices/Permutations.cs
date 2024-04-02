using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractices
{
    public static class Permutations
    {
        public static List<string> GeneratePerm(List<string> characters, List<string> perm = default)
        {
            if (perm is null)
            {
                perm = new List<string> { string.Empty };
            }

            if (characters.Count == 0)
                return perm;
            List<string> permutations = new List<string>();
            for (int i = 0; i < characters.Count; i++)
            {
                List<string> generatedPerm = perm.Select(str => str + characters[i]).ToList();
                List<string> remainingElements = characters.Where((item, index) => index != i).ToList();
                var permutation = GeneratePerm(remainingElements, generatedPerm);
                permutations = permutations.Concat(permutation).ToList();

            }
            permutations = permutations.Concat(perm).ToList();
            return permutations;
        }
    }
}
