// See https://aka.ms/new-console-template for more information
using RecursionPractices;
using System;
using System.Globalization;
using System.Linq;

static (int, int) GetIndex(List<int> numbers, int no, int start, int end)
{
    if(numbers.Count==0)
        return (-1, -1);
    if (numbers[numbers.Count-1] <=no)
        return (numbers.Count + 1, numbers.Count + 1);
    if (numbers[0] > no)
        return (- 1, - 1);
    if (end == start)
        return (end + 1, end + 1);
    if ((end - start == 1) && no >= numbers[end])
        return (end + 1, end + 1);
    if ((end - start == 1) && no < numbers[start])
        return (start - 1, start - 1);
    if ((end - start == 1) && no >= numbers[start] && no < numbers[end])
        return (start +1, start + 1);
    else
    {
        int newIndex = (end - start)/2 + start;
        if (numbers[newIndex] <= no)
            return GetIndex(numbers, no, newIndex, end);
        else
            return GetIndex(numbers, no, start, newIndex);
    }
}

List<int> numbers = new List<int> { 10, 5, 2, 7, 1, 9 };
var h = Enumerable.Range(0, numbers.Count - 2+1).Select(i => numbers.Take(i).Concat(numbers.Skip(i+2)).Min()).Min();

List<int> list1s = new List<int> { 1, 2, 3 };
List<string> list2s = new List<string> { "A", "B", "C" };

var orderedPairs = list1s.SelectMany(num => list2s, (num, str) => new { Number = num, Letter = str }).ToList();

List<int> list1 = new List<int> { 1, 2, 3 };
List<int> list2 = new List<int> { 4, 5, 6 };

var orderedPairss = list1.Select(x => list2.Select(y => (x, y)).ToList()).ToList();




var validIndices = Enumerable.Range(0, numbers.Count)
                                   .Select(start => Enumerable.Range(start, numbers.Count - start).Select(end => (start, end)))
                                   .SelectMany(x=>x);

var subArrays = validIndices.Select(index => numbers.Skip(index.Item1).Take(index.Item2 - index.Item1 + 1).ToList())
                .Where(subArray => subArray.Sum() == 15).Max(i=>i.Count);

int kk = 0;

