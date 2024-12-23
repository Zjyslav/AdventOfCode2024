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

  [Fact]
  public void Day01_Part2()
  {
    // Arrange
    string inputPath = Path.Combine("ExampleInputs", "Day01.txt");
    var input = File.ReadAllLines(inputPath);
    Day01.Solver solver = new(input);

    long expected = 31;

    // Act
    var actual = solver.SolvePart2();

    // Assert
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Day02_Part1()
  {
    // Arrange
    string inputPath = Path.Combine("ExampleInputs", "Day02.txt");
    var input = File.ReadAllLines(inputPath);
    Day02.Solver solver = new(input);

    int expected = 2;

    // Act
    var actual = solver.SolvePart1();

    // Assert
    Assert.Equal(expected, actual);
  }


  [Fact]
  public void Day02_Part2()
  {
    // Arrange
    string inputPath = Path.Combine("ExampleInputs", "Day02.txt");
    var input = File.ReadAllLines(inputPath);
    Day02.Solver solver = new(input);

    int expected = 4;

    // Act
    var actual = solver.SolvePart2();

    // Assert
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Day03_Part1()
  {
    // Arrange
    string inputPath = Path.Combine("ExampleInputs", "Day03.txt");
    var input = File.ReadAllText(inputPath);
    Day03.Solver solver = new(input);

    int expected = 161;

    // Act
    var actual = solver.SolvePart1();

    // Assert
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Day03_Part2()
  {
    // Arrange
    string inputPath = Path.Combine("ExampleInputs", "Day03_2.txt");
    var input = File.ReadAllText(inputPath);
    Day03.Solver solver = new(input);

    int expected = 48;

    // Act
    var actual = solver.SolvePart2();

    // Assert
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Day04_Part1()
  {
    // Arrange
    string inputPath = Path.Combine("ExampleInputs", "Day04.txt");
    var input = File.ReadAllLines(inputPath);
    Day04.Solver solver = new(input);

    int expected = 18;

    // Act
    var actual = solver.SolvePart1();

    // Assert
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Day04_Part2()
  {
    // Arrange
    string inputPath = Path.Combine("ExampleInputs", "Day04.txt");
    var input = File.ReadAllLines(inputPath);
    Day04.Solver solver = new(input);

    int expected = 9;

    // Act
    var actual = solver.SolvePart2();

    // Assert
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Day05_Part1()
  {
    // Arrange
    string inputPath = Path.Combine("ExampleInputs", "Day05.txt");
    var input = File.ReadAllLines(inputPath);
    Day05.Solver solver = new(input);

    int expected = 143;

    // Act
    var actual = solver.SolvePart1();

    // Assert
    Assert.Equal(expected, actual);
  }

  [Fact]
  public void Day05_Part2()
  {
    // Arrange
    string inputPath = Path.Combine("ExampleInputs", "Day05.txt");
    var input = File.ReadAllLines(inputPath);
    Day05.Solver solver = new(input);

    int expected = 123;

    // Act
    var actual = solver.SolvePart2();

    // Assert
    Assert.Equal(expected, actual);
  }

}
