using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractices
{
    public static class Permutations
    {
        public static List<string> GeneratePerm(List<string> alphabets, List<string> perm = default)
        {
            if (perm is null)
            {
                perm = new List<string> { string.Empty };
            }

            if (alphabets.Count == 0)
                return perm;

            List<(List<string>, List<string>)> x = new List<(List<string>, List<string>)>();
            List<string> dupPerm = new List<string>(perm);
            for (int i = 0; i < alphabets.Count; i++)
            {
                List<string> modifiedPerm = dupPerm.Select(str => str + alphabets[i]).ToList();
                List<string> removedAlpha = alphabets.Where((item, index) => index != i).ToList();
                x.Add((removedAlpha, modifiedPerm));

            }
            List<string> permutation = new List<string>();
            foreach (var tuple in x)
            {
                var g = GeneratePerm(tuple.Item1, tuple.Item2);
                permutation = permutation.Concat(g).ToList();
            }
            permutation = permutation.Concat(perm).ToList();
            return permutation;
        }
    }
}
