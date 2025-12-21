namespace Algorithm.BOJ.BOJ_08958
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_08958/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            while (T-- > 0)
            {
                string quizResult = Console.ReadLine()!;

                int score = 0;
                int totalScore = 0;

                foreach (char c in quizResult)
                    totalScore += score = c == 'O' ? score + 1 : 0;

                Console.WriteLine(totalScore);
            }
        }
    }
}
