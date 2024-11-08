namespace Algorithm.BOJ.BOJ_02738
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02738/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            int[,] Mat = new int[N, M];
            for (int i = 0; i < 2; i++)
            {
                for (int n = 0; n < N; n++)
                {
                    string[] row = Console.ReadLine()!.Split();
                    for (int m = 0; m < M; m++)
                    {
                        Mat[n, m] += int.Parse(row[m]);
                    }
                }
            }
            StringBuilder answer = new();
            for (int n = 0; n < N; n++)
            {
                for (int m = 0; m < M; m++)
                {
                    answer.Append($"{Mat[n, m]} ");
                }
                answer.Append('\n');
            }
            Console.WriteLine(answer);
        }
    }
}
