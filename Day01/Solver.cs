namespace AdventOfCode2024.Day01;

public class Solver
{
  private string[] _input;

  public Solver(string[] input)
  {
    _input = input;
  }

  public long SolvePart1()
  {
    var pairs = _input
      .Select(line => line.Split(" ", StringSplitOptions.RemoveEmptyEntries)
      .Select(long.Parse).ToArray())
      .ToArray();

    var list1 = pairs
      .Select(pair => pair[0])
      .Order()
      .ToList();

    var list2 = pairs
      .Select(pair => pair[1])
      .Order()
      .ToList();

    List<long> distances = [];

    for (int i = 0; i < list1.Count; i++)
    {
      var distance = Math.Abs(list1[i] - list2[i]);
      distances.Add(distance);
    }

    var sum = distances.Sum();

    return sum;
  }
}
