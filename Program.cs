using Algorithm.BOJ.BOJ_02751;

foreach (string inputPath in Solution4.InputPaths)
{
    Console.SetIn(new StringReader(File.ReadAllText(inputPath)));
    Solution4.Run([]);
}
