using AdventOfCode2024.Day04;

var input = File.ReadAllLines("input.txt");
Solver solver = new(input);

var part1Output = solver.SolvePart1();

Console.WriteLine("Day 04");
Console.WriteLine($"Part 1: {part1Output}");
