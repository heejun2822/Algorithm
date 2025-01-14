namespace Algorithm.BOJ.BOJ_11066
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11066/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            StringBuilder answer = new();

            int T = int.Parse(sr.ReadLine()!);
            for (int _ = 0; _ < T; _++)
            {
                int K = int.Parse(sr.ReadLine()!);
                int[] files = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

                int[] accSum = new int[K + 1];
                int[,] minCosts = new int[K + 1, K + 1];
                for (int e = 1; e <= K; e++)
                {
                    accSum[e] = accSum[e - 1] + files[e - 1];

                    for (int s = e - 1; s >= 1; s--)
                    {
                        minCosts[s, e] = int.MaxValue;
                        for (int i = 0; i < e - s; i++)
                            minCosts[s, e] = Math.Min(
                                minCosts[s, e],
                                minCosts[s, s + i] + minCosts[s + i + 1, e]
                            );
                        minCosts[s, e] += accSum[e] - accSum[s - 1];
                    }
                }

                answer.AppendLine(minCosts[1, K].ToString());
            }

            sw.Write(answer);

            sr.Close();
            sw.Close();
        }
    }
}
