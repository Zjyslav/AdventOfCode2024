namespace AdventOfCode2024.Day05;

public class Solver
{
  private string[] _input;
  private Dictionary<int, List<int>> _orderingRules = [];
  private List<int[]> _updates = [];


  public Solver(string[] input)
  {
    _input = input;

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

      if (!_orderingRules.ContainsKey(pages[0]))
      {
        _orderingRules[pages[0]] = [];
      }
      _orderingRules[pages[0]].Add(pages[1]);
    }

    for (int i = inputBreakIndex + 1; i < _input.Length; i++)
    {
      var update = _input[i]
        .Split(',')
        .Select(s => int.Parse(s))
        .ToArray();

      _updates.Add(update);
    }
  }

  public int SolvePart1()
  {
    int sum = 0;

    foreach (var update in _updates)
    {
      bool orderIsCorrect = IsOrderCorrect(update);

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
    int sum = 0;

    foreach (var update in _updates)
    {
      bool orderIsCorrect = IsOrderCorrect(update);

      if (orderIsCorrect)
      {
        continue;
      }

      int[] sortedUpdate = SortUpdate(update);

      int middleIndex = sortedUpdate.Length / 2;
      sum += sortedUpdate[middleIndex];
    }

    return sum;
  }

  private bool IsOrderCorrect(int[] update)
  {
    bool orderIsCorrect = true;

    for (int i = update.Length - 1; i > 0; i--)
    {
      var rules = _orderingRules.GetValueOrDefault(update[i]);
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

    return orderIsCorrect;
  }

  private int[] SortUpdate(int[] update)
  {
    int[] sortedUpdate = (int[])update.Clone();

    for (int i = 0; i < sortedUpdate.Length - 1; i++)
    {
      bool swapped = false;
      for (int j = 0; j < sortedUpdate.Length - 1; j++)
      {
        int x = sortedUpdate[j];
        int y = sortedUpdate[j + 1];

        var xRules = _orderingRules.GetValueOrDefault(x);
        var yRules = _orderingRules.GetValueOrDefault(y);

        if (xRules?.Contains(y) == true)
        {
          continue;
        }

        if (yRules?.Contains(x) == true)
        {
          sortedUpdate[j] = y;
          sortedUpdate[j + 1] = x;
          swapped = true;
        }
      }

      if (!swapped)
      {
        break;
      }
    }

    return sortedUpdate;
  }
}
