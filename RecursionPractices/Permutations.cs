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

            List<(List<string>, List<string>)> breadthRepo = new List<(List<string>, List<string>)>();
            for (int i = 0; i < characters.Count; i++)
            {
                List<string> generatedPerm = perm.Select(str => str + characters[i]).ToList();
                List<string> remainingElements = characters.Where((item, index) => index != i).ToList();
                breadthRepo.Add((remainingElements, generatedPerm));

            }
            List<string> permutation = new List<string>();
            foreach (var node in breadthRepo)
            {
                var g = GeneratePerm(node.Item1, node.Item2);
                permutation = permutation.Concat(g).ToList();
            }
            permutation = permutation.Concat(perm).ToList();
            return permutation;
        }
    }
}
