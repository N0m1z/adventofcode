using System.Text.RegularExpressions;

namespace AdventOfCode2023.Day2;

public partial class Day2(string pathToInput) : ProblemSolver(pathToInput)
{
    public override string SolveProblem1()
    {
        return InputLines
            .Select((l, i) => (GameId: i + 1,
                MaxBlueCount: BlueRegex().Matches(l)
                    .Select(m => int.Parse(m.Value.Split(" ")[0]))
                    .Max(),
                MaxGreenCount: GreenRegex().Matches(l)
                    .Select(m => int.Parse(m.Value.Split(" ")[0]))
                    .Max(),
                MaxRedCount: RedRegex().Matches(l)
                    .Select(m => int.Parse(m.Value.Split(" ")[0]))
                    .Max()))
            .Where(e => e.MaxBlueCount <= 14 && e.MaxGreenCount <= 13 && e.MaxRedCount <= 12)
            .Sum(e => e.GameId)
            .ToString();
    }

    public override string SolveProblem2()
    {
        return InputLines
            .Select((l, i) => (
                MaxBlueCount: BlueRegex().Matches(l)
                    .Select(m => int.Parse(m.Value.Split(" ")[0]))
                    .Max(),
                MaxGreenCount: GreenRegex().Matches(l)
                    .Select(m => int.Parse(m.Value.Split(" ")[0]))
                    .Max(),
                MaxRedCount: RedRegex().Matches(l)
                    .Select(m => int.Parse(m.Value.Split(" ")[0]))
                    .Max()))
            .Select(e => e.MaxBlueCount * e.MaxGreenCount * e.MaxRedCount)
            .Sum()
            .ToString();
    }
    
    [GeneratedRegex(@"\d+ blue")]
    private static partial Regex BlueRegex();
    
    [GeneratedRegex(@"\d+ green")]
    private static partial Regex GreenRegex();
    
    [GeneratedRegex(@"\d+ red")]
    private static partial Regex RedRegex();
}