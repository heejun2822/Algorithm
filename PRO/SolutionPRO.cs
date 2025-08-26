namespace Algorithm.PRO
{
    public class SolutionPRO<T> : SolutionBase where T : ISolutionPRO
    {
        public override void Solve(string[] args)
        {
            foreach (string inputPath in T.InputPaths)
            {
                Program.SetReader(inputPath);
                Run(args);
            }
        }

        public virtual void Run(string[] args) {}
    }

    public interface ISolutionPRO : ISolutionBase
    {

    }
}
