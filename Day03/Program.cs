using AdventOfCode2024.Day03;

var input = File.ReadAllText("input.txt");
Solver solver = new(input);

var part1Output = solver.SolvePart1();
var part2Output = solver.SolvePart2();

Console.WriteLine("Day 01");
Console.WriteLine($"Part 1: {part1Output}");
Console.WriteLine($"Part 2: {part2Output}");
