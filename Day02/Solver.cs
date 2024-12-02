namespace AdventOfCode2024.Day02;

public class Solver
{
  private string[] _input;

  public Solver(string[] input)
  {
    _input = input;
  }

  public int SolvePart1()
  {
    int minChange = 1;
    int maxChange = 3;

    List<int[]> reports = _input
      .Select(line => line.Split(' ').Select(x => int.Parse(x)).ToArray())
      .ToList();

    int safeCount = 0;

    foreach (var report in reports)
    {
      bool safe = true;
      bool increasing = report[1] > report[0];

      for (int i = 1; i < report.Length; i++)
      {
        int change = increasing
          ? report[i] - report[i - 1]
          : report[i - 1] - report[i];

        if (change < minChange ||
            change > maxChange)
        {
          safe = false;
          break;
        }
      }

      if (safe)
      {
        safeCount++;
      }
    }

    return safeCount;
  }

  public int SolvePart2()
  {
    throw new NotImplementedException();
  }
}
