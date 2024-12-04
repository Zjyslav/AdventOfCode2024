namespace AdventOfCode2024.Day04;

public class Solver
{
  private readonly char[][] _input;
  private readonly char[] _xmas = "XMAS".ToCharArray();
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

    int matchCount = 0;
    for (int row = 0; row < rowCount; row++)
    {
      for (int col = 0; col < colCount; col++)
      {
        matchCount += CountMatches(row, col);
      }
    }

    return matchCount;
  }

  public int SolvePart2()
  {
    throw new NotImplementedException();
  }

  private int CountMatches(int row, int col)
  {
    int matchCount = 0;
    if (row >= _input.Length ||
        col >= _input[row].Length ||
        _input[row][col] != _xmas[0])
    {
      return matchCount;
    }

    if (IsMatchHorizontalForward(row, col)) matchCount++;
    if (IsMatchHorizontalBackward(row, col)) matchCount++;
    if (IsMatchVerticalForward(row, col)) matchCount++;
    if (IsMatchVerticalBackward(row, col)) matchCount++;
    if (IsMatchDiagonalForwardUp(row, col)) matchCount++;
    if (IsMatchDiagonalForwardDown(row, col)) matchCount++;
    if (IsMatchDiagonalBackwardUp(row, col)) matchCount++;
    if (IsMatchDiagonalBackwardDown(row, col)) matchCount++;

    return matchCount;
  }

  private bool IsMatchHorizontalForward(int row, int col)
  {
    if (_input[row].Length - col < 4)
    {
      return false;
    }

    return _input[row][col + 1] == _xmas[1] &&
           _input[row][col + 2] == _xmas[2] &&
           _input[row][col + 3] == _xmas[3];
  }

  private bool IsMatchHorizontalBackward(int row, int col)
  {
    if (col < 3)
    {
      return false;
    }

    return _input[row][col - 1] == _xmas[1] &&
           _input[row][col - 2] == _xmas[2] &&
           _input[row][col - 3] == _xmas[3];
  }

  private bool IsMatchVerticalForward(int row, int col)
  {
    if (_input.Length - row < 4)
    {
      return false;
    }

    return _input[row + 1][col] == _xmas[1] &&
           _input[row + 2][col] == _xmas[2] &&
           _input[row + 3][col] == _xmas[3];
  }

  private bool IsMatchVerticalBackward(int row, int col)
  {
    if (row < 3)
    {
      return false;
    }

    return _input[row - 1][col] == _xmas[1] &&
           _input[row - 2][col] == _xmas[2] &&
           _input[row - 3][col] == _xmas[3];
  }

  private bool IsMatchDiagonalForwardUp(int row, int col)
  {
    if (row < 3 ||
        _input[row].Length - col < 4)
    {
      return false;
    }

    return _input[row - 1][col + 1] == _xmas[1] &&
           _input[row - 2][col + 2] == _xmas[2] &&
           _input[row - 3][col + 3] == _xmas[3];
  }

  private bool IsMatchDiagonalForwardDown(int row, int col)
  {
    if (_input.Length - row < 4 ||
        _input[row].Length - col < 4)
    {
      return false;
    }

    return _input[row + 1][col + 1] == _xmas[1] &&
           _input[row + 2][col + 2] == _xmas[2] &&
           _input[row + 3][col + 3] == _xmas[3];
  }


  private bool IsMatchDiagonalBackwardUp(int row, int col)
  {
    if (row < 3 ||
        col < 3)
    {
      return false;
    }

    return _input[row - 1][col - 1] == _xmas[1] &&
           _input[row - 2][col - 2] == _xmas[2] &&
           _input[row - 3][col - 3] == _xmas[3];
  }

  private bool IsMatchDiagonalBackwardDown(int row, int col)
  {
    if (_input.Length - row < 4 ||
        col < 3)
    {
      return false;
    }

    return _input[row + 1][col - 1] == _xmas[1] &&
           _input[row + 2][col - 2] == _xmas[2] &&
           _input[row + 3][col - 3] == _xmas[3];
  }
}
