namespace Algorithm.BOJ.BOJ_10951
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10951/input.txt",
        ];

        public static void Run(string[] args)
        {
            System.Text.StringBuilder answer = new();
            while (true)
            {
                string? input = Console.ReadLine();
                if (input == null) break;
                string[] numbers = input.Split();
                int A = int.Parse(numbers[0]);
                int B = int.Parse(numbers[1]);
                answer.AppendLine((A + B).ToString());
            }
            Console.WriteLine(answer);
        }
    }
}
