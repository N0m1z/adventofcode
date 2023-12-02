namespace AdventOfCode2023;

public abstract class ProblemSolver(string pathToInput)
{
    protected string Input = File.ReadAllText(pathToInput);
    protected readonly string[] InputLines = File.ReadAllLines(pathToInput);
    
    public virtual string SolveProblem1() => "Not implemented";
    public virtual string SolveProblem2() => "Not implemented";
}