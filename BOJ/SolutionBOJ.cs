namespace Algorithm
{
    public abstract class SolutionBOJ : ISolution
    {
        protected abstract string[] InputPaths { get; set; }

        public abstract void Run();

        public void Test()
        {
            foreach (string inputPath in InputPaths)
            {
                Console.SetIn(new StringReader(File.ReadAllText(inputPath)));
                Run();
            }
        }
    }
}
