﻿// See https://aka.ms/new-console-template for more information
using RecursionPractices;



static void Reverse(StackList stack)
{


}

Console.WriteLine("Hello, World!");
List<string> characters = new List<string> { "a", "b", "c", "d", "e"};
var permutations = Permutations.GeneratePermutations(characters);
bool x = Permutations.ValidateDerangement(characters, "adacb");
var permutationss = Permutations.GenerateDerangements(characters);
var permutationsx = Permutations.GenerateNPermutations(characters, 2);
List<int> numbers1 = Enumerable.Range(1, 2).ToList();
List<int> numbers2 = Enumerable.Range(4, 10).ToList();
Func<(bool, int)> numbers1Iter = Permutations.GetIterator(numbers1);
Func<(bool, int)> numbers2Iter = Permutations.GetIterator(numbers2);

var number1 = numbers1Iter();
var number2 = numbers2Iter();
List<int> sortedList = new List<int>();
while(true)
{
    if (number1.Item1 == false && number2.Item1 == false)
        break;
    else if(number1.Item1 == true && number2.Item1 == true)
    {
        if(number2.Item2 == number1.Item2)
        {
            sortedList.Add(number2.Item2);
            sortedList.Add(number1.Item2);
            number1 = numbers1Iter();
            number2 = numbers2Iter();

        }
        else if(number2.Item2 < number1.Item2)
        {
            sortedList.Add(number2.Item2);
            number2 = numbers2Iter();

        }
        else
        {
            sortedList.Add(number1.Item2);
            number1 = numbers1Iter();
        }
    }
    else if(number1.Item1 == true)
    {
        sortedList.Add(number1.Item2);
        number1 = numbers1Iter();
    }
    else
    {
        sortedList.Add(number2.Item2);
        number2 = numbers2Iter();
    }

}

List<int> nums = new List<int>();

StackList stack = new StackList(nums);
stack.push(1);
stack.push(2);
stack.push(49);
stack.push(50);
StackMethods.SortInsert(stack, 3);
var a = stack.pop();
var b = stack.pop();
var c = stack.pop();
var d = stack.pop();
var e = stack.pop();

List<int> numbers = new List<int> { 1, 2, 3, 4 };
var nos = StackMethods.NextGreaterElement(numbers);
QueueList queue = new QueueList();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

QueueMethods.reverse(queue);
string name  = QueueMethods.PrintElements(queue);
int f = queue.Dequeue();
int f1 = queue.Dequeue();
int g1 = queue.Dequeue();
int hhh = 0;








