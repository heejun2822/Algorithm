using Algorithm.BOJ.BOJ_11653;

foreach (string inputPath in Solution2.InputPaths)
{
    Console.SetIn(new StringReader(File.ReadAllText(inputPath)));
    Solution2.Run([]);
}
