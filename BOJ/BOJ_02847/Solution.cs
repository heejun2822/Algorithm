namespace Algorithm.BOJ.BOJ_02847
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02847/input1.txt",
            "BOJ/BOJ_02847/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] scores = new int[N];

            for (int i = 0; i < N; i++)
                scores[i] = int.Parse(Console.ReadLine()!);

            int cnt = 0;

            for (int i = N - 2; i >= 0; i--)
            {
                if (scores[i] >= scores[i + 1])
                {
                    cnt += scores[i] - (scores[i + 1] - 1);
                    scores[i] = scores[i + 1] - 1;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
