namespace Algorithm.BOJ
{
    public class SolutionBOJ<T> : SolutionBase where T : ISolutionBOJ
    {
        public override void Solve(string[] args)
        {
            foreach (string inputPath in T.InputPaths)
            {
                Program.SetReader(inputPath);
                T.Run(args);
            }
        }
    }

    public interface ISolutionBOJ : ISolutionBase
    {
        public static abstract void Run(string[] args);
    }
}
