using Algorithm.BOJ.BOJ_01193;

foreach (string inputPath in Solution.InputPaths)
{
    Console.SetIn(new StringReader(File.ReadAllText(inputPath)));
    Solution.Run([]);
}
