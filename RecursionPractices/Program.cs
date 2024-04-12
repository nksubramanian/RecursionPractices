// See https://aka.ms/new-console-template for more information
using RecursionPractices;
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

List<int> numbers = new List<int> { 1, 2,3,5,6,7};
var h = GetIndex(numbers, 4, 0, numbers.Count-1);
int i = 0;




