// See https://aka.ms/new-console-template for more information
using RecursionPractices;
using System;
using System.Globalization;
using System.Linq;


List<int> costs = new List<int> { 1, 12, 5, 111, 200, 1000, 10 };
List<(List<int>, int)> comb = new List<(List<int>, int)>();
foreach(var cost in costs)
{
    comb = comb.Select(x => (x.Item1.Append(cost).ToList(), x.Item2 + cost)).Where(x=>x.Item2<=50).Concat(comb).ToList();
    if(cost<=50)
    {
        comb.Add((new List<int> { cost }, cost));
    }


}
var g = comb.OrderByDescending(x=>x.Item1.Count()).FirstOrDefault().ToTuple();
int fff = 0;

