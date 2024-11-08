using Algorithm.BOJ.BOJ_10798;

foreach (string inputPath in Solution2.InputPaths)
{
    Console.SetIn(new StringReader(File.ReadAllText(inputPath)));
    Solution2.Run([]);
}
