// See https://aka.ms/new-console-template for more information
using RecursionPractices;
using System;
using System.Globalization;
using System.Linq;
using System.Numerics;

List<(int, int)> rec = new List<(int, int)> ();
int K = 4;
List<int> ans = new List<int> ();
List<int> nums = new List<int> { 7,6,5,4,3,2,1 };
for(int i = 0; i<=nums.Count()-K;++i)
{
    if(i==0)
    {
        rec = Enumerable.Range(0, K).Select(i => (nums[i],i)).ToList();
    }
    else
    {
        rec.Add((nums[i + K - 1], i + K - 1));
    }

    rec = rec.OrderByDescending(x => x.Item1).ToList();
    rec = rec.Where((num, index) =>
    {
        return Enumerable.Range(0, index).Select(x => rec[index].Item2 > rec[x].Item2)
        .Aggregate(true, (acc, n) => acc && n);
    }).Where(x=>x.Item2>=i).ToList();
    ans.Add(rec[0].Item1);
    
}

int h = 0;
