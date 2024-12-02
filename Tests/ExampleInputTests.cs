namespace AdventOfCode2024.Tests;
public class ExampleInputTests
{
  [Fact]
  public void Day01_Part1()
  {
    // Arrange
    string inputPath = Path.Combine("ExampleInputs", "Day01.txt");
    var input = File.ReadAllLines(inputPath);
    Day01.Solver solver = new(input);

    long expected = 11;

    // Act
    var actual = solver.SolvePart1();

    // Assert
    Assert.Equal(expected, actual);
  }
}
