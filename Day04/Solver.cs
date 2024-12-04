namespace AdventOfCode2024.Day04;

public class Solver
{
  private readonly char[][] _input;
  public Solver(string[] input)
  {
    _input = input
      .Select(s => s.ToCharArray())
      .ToArray();
  }

  public int SolvePart1()
  {
    int rowCount = _input.Length;
    int colCount = _input[0].Length;

    char[] xmas = "XMAS".ToCharArray();

    int matchCount = 0;
    for (int row = 0; row < rowCount; row++)
    {
      for (int col = 0; col < colCount; col++)
      {
        matchCount += CountMatches(row, col, xmas);
      }
    }

    return matchCount;
  }

  public int SolvePart2()
  {
    throw new NotImplementedException();
  }

  private int CountMatches(int row, int col, char[] phrase)
  {
    int matchCount = 0;
    if (row >= _input.Length ||
        col >= _input[row].Length ||
        _input[row][col] != phrase[0])
    {
      return matchCount;
    }

    if (IsMatchHorizontalForward(row, col, phrase)) matchCount++;
    if (IsMatchHorizontalBackward(row, col, phrase)) matchCount++;
    if (IsMatchVerticalForward(row, col, phrase)) matchCount++;
    if (IsMatchVerticalBackward(row, col, phrase)) matchCount++;
    if (IsMatchDiagonalForwardUp(row, col, phrase)) matchCount++;
    if (IsMatchDiagonalForwardDown(row, col, phrase)) matchCount++;
    if (IsMatchDiagonalBackwardUp(row, col, phrase)) matchCount++;
    if (IsMatchDiagonalBackwardDown(row, col, phrase)) matchCount++;

    return matchCount;
  }

  private bool IsMatchHorizontalForward(int row, int col, char[] phrase)
  {
    if (_input[row].Length - col < phrase.Length)
    {
      return false;
    }

    for (int i = 1; i < phrase.Length; i++)
    {
      if (_input[row][col + i] != phrase[i])
      {
        return false;
      }
    }
    return true;
  }

  private bool IsMatchHorizontalBackward(int row, int col, char[] phrase)
  {
    if (col < phrase.Length - 1)
    {
      return false;
    }

    for (int i = 1; i < phrase.Length; i++)
    {
      if (_input[row][col - i] != phrase[i])
      {
        return false;
      }
    }
    return true;
  }

  private bool IsMatchVerticalForward(int row, int col, char[] phrase)
  {
    if (_input.Length - row < phrase.Length)
    {
      return false;
    }

    for (int i = 1; i < phrase.Length; i++)
    {
      if (_input[row + i][col] != phrase[i])
      {
        return false;
      }
    }
    return true;
  }

  private bool IsMatchVerticalBackward(int row, int col, char[] phrase)
  {
    if (row < phrase.Length - 1)
    {
      return false;
    }

    for (int i = 1; i < phrase.Length; i++)
    {
      if (_input[row - i][col] != phrase[i])
      {
        return false;
      }
    }
    return true;
  }

  private bool IsMatchDiagonalForwardUp(int row, int col, char[] phrase)
  {
    if (row < phrase.Length - 1 ||
        _input[row].Length - col < phrase.Length)
    {
      return false;
    }

    for (int i = 1; i < phrase.Length; i++)
    {
      if (_input[row - i][col + i] != phrase[i])
      {
        return false;
      }
    }
    return true;
  }

  private bool IsMatchDiagonalForwardDown(int row, int col, char[] phrase)
  {
    if (_input.Length - row < phrase.Length ||
        _input[row].Length - col < phrase.Length)
    {
      return false;
    }

    for (int i = 1; i < phrase.Length; i++)
    {
      if (_input[row + i][col + i] != phrase[i])
      {
        return false;
      }
    }
    return true;
  }

  private bool IsMatchDiagonalBackwardUp(int row, int col, char[] phrase)
  {
    if (row < phrase.Length - 1 ||
        col < phrase.Length - 1)
    {
      return false;
    }

    for (int i = 1; i < phrase.Length; i++)
    {
      if (_input[row - i][col - i] != phrase[i])
      {
        return false;
      }
    }
    return true;
  }

  private bool IsMatchDiagonalBackwardDown(int row, int col, char[] phrase)
  {
    if (_input.Length - row < phrase.Length ||
        col < phrase.Length - 1)
    {
      return false;
    }

    for (int i = 1; i < phrase.Length; i++)
    {
      if (_input[row + i][col - i] != phrase[i])
      {
        return false;
      }
    }
    return true;
  }
}
