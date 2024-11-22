using Algorithm.BOJ.BOJ_02587;

foreach (string inputPath in Solution.InputPaths)
{
    Console.SetIn(new StringReader(File.ReadAllText(inputPath)));
    Solution.Run([]);
}
