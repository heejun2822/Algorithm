namespace Algorithm.BOJ.BOJ_15552
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15552/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            System.Text.StringBuilder answer = new();
            for (int i = 0; i < T; i++)
            {
                string[] numbers = Console.ReadLine()!.Split();
                answer.AppendLine((int.Parse(numbers[0]) + int.Parse(numbers[1])).ToString());
            }
            Console.WriteLine(answer);
        }
    }
}
