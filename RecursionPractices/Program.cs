// See https://aka.ms/new-console-template for more information
using RecursionPractices;
using System;
using System.Globalization;
using System.Linq;




var jj = Enumerable.Range(1, 7).ToList();
List<int> costs = new List<int> { 1, 0, 1, 1, 1, 0, 0 };
var hhhhhh = costs.Count(i => i == 1);
var subArrays = Enumerable.Range(0, costs.Count)
    .SelectMany(skip => Enumerable.Range(1, costs.Count - skip).Select(take => (skip, take)))
    .Select(index => { 
    
        return (index.Item1, index.Item2, costs.Skip(index.Item1).Take(index.Item2).ToList());

    }).Where(x =>
    {
        return x.Item3.Count(y => y == 0) == x.Item3.Count(y => y == 1);
    }).ToList();

//var g = subArrays.Where(subArray=> subArray.Where(i => i == 1).Count() == subArray.Where(i => i == 0).Count()).ToList();

var hhh = 0;
