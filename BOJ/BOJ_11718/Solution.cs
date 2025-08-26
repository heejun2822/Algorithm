namespace Algorithm.BOJ.BOJ_11718
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11718/input.txt",
        ];

        public static void Run(string[] args)
        {
            System.Text.StringBuilder input = new();
            for (int i = 0; i < 100; i++)
            {
                string? line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) break;
                input.AppendLine(line);
            }
            Console.WriteLine(input);
        }
    }
}
