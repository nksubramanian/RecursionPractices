// See https://aka.ms/new-console-template for more information
using RecursionPractices;
using System;
using System.Globalization;
using System.Linq;




var jj = Enumerable.Range(1, 7).ToList();
List<int> costs = new List<int> { 1, 1, 1, 1 };
var subArrays = Enumerable.Range(0, costs.Count)
    .SelectMany(skip => Enumerable.Range(1, costs.Count - skip).Select(take => (skip, take)))
    .Where(index =>
    {
        var subarray = costs.Skip(index.Item1).Take(index.Item2).ToList();
        return subarray.Count(x => x == 0) == subarray.Count(x => x == 1);

    }).OrderByDescending(x => x.Item2).FirstOrDefault();

//var g = subArrays.Where(subArray=> subArray.Where(i => i == 1).Count() == subArray.Where(i => i == 0).Count()).ToList();

var hhh = 0;
