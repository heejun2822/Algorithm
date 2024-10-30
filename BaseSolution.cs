public abstract class BaseSolution
{
    protected abstract string[] InputPaths { get; set; }

    protected abstract void Run();

    public void Test()
    {
        foreach (string inputPath in InputPaths)
        {
            Console.SetIn(new StringReader(File.ReadAllText(inputPath)));
            Run();
        }
    }
}
