using System.Text.RegularExpressions;

namespace AdventOfCode2023.Day1;

public partial class Day1(string pathToInput) : ProblemSolver(pathToInput)
{
    public override string SolveProblem1()
    {
        return InputLines
            .Select(l => DigitRegex().Matches(l).First().Value + DigitRegex().Matches(l).Last().Value)
            .Select(int.Parse)
            .Sum()
            .ToString();
    }

    public override string SolveProblem2()
    {
        return InputLines
            .Select(l => DigitRegex2().Match(l).Value + DigitRegex3().Match(l).Value)
            .Select(l => l
                .Replace("one", "1")
                .Replace("two", "2")
                .Replace("three", "3")
                .Replace("four", "4")
                .Replace("five", "5")
                .Replace("six", "6")
                .Replace("seven", "7")
                .Replace("eight", "8")
                .Replace("nine", "9"))
            .Select(int.Parse)
            .Sum()
            .ToString();
    }

    [GeneratedRegex(@"\d")]
    private static partial Regex DigitRegex();

    [GeneratedRegex(@"one|two|three|four|five|six|seven|eight|nine|[0-9]")]
    private static partial Regex DigitRegex2();
    
    [GeneratedRegex(@"one|two|three|four|five|six|seven|eight|nine|[0-9]", RegexOptions.RightToLeft)]
    private static partial Regex DigitRegex3();
}