namespace AdventOfCode2024.Day02;

public class Solver
{
  private string[] _input;
  private const int _minChange = 1;
  private const int _maxChange = 3;

  public Solver(string[] input)
  {
    _input = input;
  }

  public int SolvePart1()
  {
    List<int[]> reports = _input
      .Select(line => line.Split(' ').Select(x => int.Parse(x)).ToArray())
      .ToList();

    int safeCount = 0;

    foreach (var report in reports)
    {
      bool safe = IsReportSafe(report);
      if (safe)
      {
        safeCount++;
      }
    }

    return safeCount;
  }

  public int SolvePart2()
  {
    List<int[]> reports = _input
      .Select(line => line.Split(' ').Select(x => int.Parse(x)).ToArray())
      .ToList();

    int safeCount = 0;

    foreach (var report in reports)
    {
      bool safe = IsReportSafe(report);

      if (!safe)
      {
        for (int i = 0; i < report.Length; i++)
        {
          safe = IsReportSafe(DampenLevel(report, i));
          if (safe)
          {
            break;
          }
        }
      }

      if (safe)
      {
        safeCount++;
      }
    }

    return safeCount;
  }

  private static int[] DampenLevel(int[] report, int index)
  {
    if (index == 0)
    {
      return report[1..];
    }

    if (index == report.Length - 1)
    {
      return report[..^1];
    }

    return [.. report[..index], .. report[(index + 1)..]];
  }

  private bool IsReportSafe(int[] report)
  {
    bool increasing = report[1] > report[0];

    for (int i = 0; i < report.Length - 1; i++)
    {
      int change = increasing
        ? report[i + 1] - report[i]
        : report[i] - report[i + 1];

      if (change < _minChange ||
          change > _maxChange)
      {
        return false;
      }
    }

    return true;
  }
}
