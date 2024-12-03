using System.Text.RegularExpressions;

namespace AdventOfCode2024.Day03;

public partial class Solver
{
  private string _input;

  [GeneratedRegex(@"mul\((\d+),(\d+)\)")]
  private static partial Regex InstructionsRegex();

  [GeneratedRegex(@"do\(\)")]
  private static partial Regex DoRegex();

  [GeneratedRegex(@"don\'t\(\)")]
  private static partial Regex DontRegex();


  public Solver(string input)
  {
    _input = input;
  }

  public long SolvePart1()
  {
    List<long> results = [];

    var regex = InstructionsRegex();

    var matches = regex.Matches(_input);
    foreach (Match match in matches)
    {
      long number1 = long.Parse(match.Groups[1].Value);
      long number2 = long.Parse(match.Groups[2].Value);

      results.Add(number1 * number2);
    }
    return results.Sum();
  }

  public long SolvePart2()
  {
    List<long> results = [];

    var instructionMatches = InstructionsRegex().Matches(_input);
    var doMatches = DoRegex().Matches(_input);
    var dontMatches = DontRegex().Matches(_input);

    var doIndexes = doMatches
      .Select(m => m.Index);

    var dontIndexes = dontMatches
      .Select(m => m.Index);

    foreach (Match match in instructionMatches)
    {
      int index = match.Index;
      int lastDo = doIndexes
        .LastOrDefault(i => i < index);

      int lastDont = dontIndexes
        .LastOrDefault(i => i < index);

      if (lastDont > lastDo)
      {
        continue;
      }

      long number1 = long.Parse(match.Groups[1].Value);
      long number2 = long.Parse(match.Groups[2].Value);

      results.Add(number1 * number2);
    }

    return results.Sum();
  }
}
