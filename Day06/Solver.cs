using Vector = (int X, int Y);

namespace AdventOfCode2024.Day06;

public class Solver
{
  private string[] _input;
  private char[][] _map;

  const int upX = -1;
  const int upY = 0;
  private Vector _up = (upX, upY);

  const int downX = 1;
  const int downY = 0;
  private Vector _down = (downX, downY);

  const int leftX = 0;
  const int leftY = -1;
  private Vector _left = (leftX, leftY);

  const int rightX = 0;
  const int rightY = 1;
  private Vector _right = (rightX, rightY);

  public Solver(string[] input)
  {
    _input = input;

    _map = _input
      .Select(l => l.ToCharArray())
      .ToArray();
  }

  public int SolvePart1()
  {
    Vector guardPosition = GetGuardPosition(_map, '^');

    Console.WriteLine(guardPosition);

    HashSet<Vector> visitedPositions = [guardPosition];

    Vector guardDirection = _up;

    while (true)
    {

      Vector newPosition = (guardPosition.X + guardDirection.X,
                            guardPosition.Y + guardDirection.Y);

      if (newPosition.X >= _map.Length ||
          newPosition.X < 0 ||
          newPosition.Y >= _map[newPosition.X].Length ||
          newPosition.Y < 0)
      {
        break;
      }

      if (_map[newPosition.X][newPosition.Y] == '#')
      {
        guardDirection = guardDirection switch
        {
          (upX, upY) => _right,
          (rightX, rightY) => _down,
          (downX, downY) => _left,
          (leftX, leftY) => _up,
          _ => throw new InvalidOperationException("Incorrect guard direction.")
        };
        continue;
      }

      guardPosition = newPosition;
      visitedPositions.Add(guardPosition);
    }

    return visitedPositions.Count;
  }

  public int SolvePart2()
  {
    throw new NotImplementedException();
  }

  private static Vector GetGuardPosition(char[][] map, char guard)
  {
    for (int x = 0; x < map.Length; x++)
    {
      for (int y = 0; y < map[x].Length; y++)
      {
        if (map[x][y] == guard)
        {
          return (x, y);
        }
      }
    }

    return (-1, -1);
  }
}
