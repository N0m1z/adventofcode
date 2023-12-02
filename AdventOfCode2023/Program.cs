// See https://aka.ms/new-console-template for more information

using AdventOfCode2023.Day1;
using AdventOfCode2023.Day2;

Console.WriteLine("Result 1:");

var day = new Day2("Day2/input.txt");
Console.WriteLine(day.SolveProblem1());

Console.WriteLine("Result 2:");
Console.WriteLine(day.SolveProblem2());
