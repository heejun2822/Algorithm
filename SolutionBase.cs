namespace Algorithm
{
    public abstract class SolutionBase
    {
        public abstract void Solve(string[] args);
    }

    public interface ISolutionBase
    {
        public static abstract string[] InputPaths { get; set; }
    }
}
