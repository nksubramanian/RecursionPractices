﻿// See https://aka.ms/new-console-template for more information
using RecursionPractices;

Console.WriteLine("Hello, World!");
List<string> characters = new List<string> { "a", "b", "c", "d", "e"};
var permutations = Permutations.GeneratePermutations(characters);
bool x = Permutations.ValidateDerangement(characters, "adacb");
var permutationss = Permutations.GenerateDerangements(characters);
var permutationsx = Permutations.GenerateNPermutations(characters, 2); 
int j = 0;


