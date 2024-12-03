using System.Text.RegularExpressions;

namespace AdventOfCode2024.Day03;

public partial class Solver
{
  private string[] _input;

  [GeneratedRegex(@"mul\((\d+),(\d+)\)")]
  private static partial Regex InstructionsRegex();

  public Solver(string[] input)
  {
    _input = input;
  }

  public long SolvePart1()
  {
    List<long> results = [];

    var regex = InstructionsRegex();

    foreach (var line in _input)
    {
      var matches = regex.Matches(line);
      foreach (Match match in matches)
      {
        long number1 = long.Parse(match.Groups[1].Value);
        long number2 = long.Parse(match.Groups[2].Value);

        results.Add(number1 * number2);
      }
    }

    return results.Sum();
  }

  public long SolvePart2()
  {
    throw new NotImplementedException();
  }
}
