namespace Algorithm.BOJ.BOJ_11021
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11021/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            System.Text.StringBuilder answer = new();
            for (int i = 1; i <= T; i++)
            {
                string[] numbers = Console.ReadLine()!.Split();
                int A = int.Parse(numbers[0]);
                int B = int.Parse(numbers[1]);
                answer.AppendLine($"Case #{i}: {A + B}");
            }
            Console.WriteLine(answer);
        }
    }
}
