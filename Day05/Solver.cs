namespace AdventOfCode2024.Day05;

public class Solver
{
  private string[] _input;
  public Solver(string[] input)
  {
    _input = input;
  }

  public int SolvePart1()
  {
    Dictionary<int, List<int>> orderingRules = [];
    List<int[]> updates = [];

    int inputBreakIndex = 0;

    for (int i = 0; i < _input.Length; i++)
    {
      if (_input[i] == string.Empty)
      {
        inputBreakIndex = i;
        break;
      }

      var pages = _input[i]
        .Split('|')
        .Select(s => int.Parse(s))
        .ToArray();

      if (!orderingRules.ContainsKey(pages[0]))
      {
        orderingRules[pages[0]] = [];
      }
      orderingRules[pages[0]].Add(pages[1]);
    }

    for (int i = inputBreakIndex + 1; i < _input.Length; i++)
    {
      var update = _input[i]
        .Split(',')
        .Select(s => int.Parse(s))
        .ToArray();

      updates.Add(update);
    }

    int sum = 0;

    foreach (var update in updates)
    {
      bool orderIsCorrect = true;

      for (int i = update.Length - 1; i > 0; i--)
      {
        var rules = orderingRules.GetValueOrDefault(update[i]);
        if (rules is null)
        {
          continue;
        }

        for (int j = 0; j < i; j++)
        {
          if (rules.Contains(update[j]))
          {
            orderIsCorrect = false;
          }
        }
      }

      if (orderIsCorrect)
      {
        int middleIndex = update.Length / 2;
        sum += update[middleIndex];
      }
    }

    return sum;
  }

  public int SolvePart2()
  {
    throw new NotImplementedException();
  }
}
