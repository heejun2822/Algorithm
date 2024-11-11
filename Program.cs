using Algorithm.BOJ.BOJ_02745;

foreach (string inputPath in Solution.InputPaths)
{
    Console.SetIn(new StringReader(File.ReadAllText(inputPath)));
    Solution.Run([]);
}
