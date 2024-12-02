namespace AdventOfCode2024.Day01;

public class Solver
{
  private string[] _input;
  private IOrderedEnumerable<long> _leftNumbers;
  private IOrderedEnumerable<long> _rightNumbers;

  public Solver(string[] input)
  {
    _input = input;

    var pairs = _input
      .Select(line =>
          line.Split(" ", StringSplitOptions.RemoveEmptyEntries)
              .Select(long.Parse).ToArray())
      .ToArray();

    _leftNumbers = pairs
      .Select(pair => pair[0])
      .Order();

    _rightNumbers = pairs
      .Select(pair => pair[1])
      .Order();
  }

  public long SolvePart1()
  {
    var leftNumbers = _leftNumbers.ToArray();
    var rightNumbers = _rightNumbers.ToArray();

    List<long> distances = [];


    for (int i = 0; i < _input.Length; i++)
    {
      var distance = Math.Abs(leftNumbers[i] - rightNumbers[i]);
      distances.Add(distance);
    }

    var sum = distances.Sum();

    return sum;
  }

  public long SolvePart2()
  {
    var counts = _rightNumbers
      .Distinct()
      .ToDictionary(
          number => number,
          number => _rightNumbers.Count(x => x == number));

    List<long> similarityScores = [];

    foreach (var number in _leftNumbers)
    {
      int count = counts.GetValueOrDefault(number);
      long score = number * count;
      similarityScores.Add(score);
    }

    var sum = similarityScores.Sum();

    return sum;
  }
}
