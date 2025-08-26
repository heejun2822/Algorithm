namespace Algorithm.BOJ.BOJ_03447
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_03447/input.txt",
        ];

        public static void Run(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine()!;
                if (line == null) return;
                while (line.Contains("BUG")) line = line.Replace("BUG", "");
                Console.WriteLine(line);
            }
        }
    }
}
