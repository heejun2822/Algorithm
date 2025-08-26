namespace Algorithm.BOJ.BOJ_11062
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11062/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                int N = int.Parse(sr.ReadLine()!);
                int[] cards = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

                int[,] maxSum = new int[N, N];
                bool isTurn = N % 2 == 1;

                for (int cnt = 1; cnt <= N; cnt++)
                {
                    for (int left = 0, right = left + cnt - 1; right < N; left++, right++)
                    {
                        if (cnt == 1)
                        {
                            if (isTurn)
                                maxSum[left, right] = cards[left];
                            else
                                maxSum[left, right] = 0;
                        }
                        else
                        {
                            if (isTurn)
                                maxSum[left, right] = Math.Max(
                                    cards[left] + maxSum[left + 1, right],
                                    cards[right] + maxSum[left, right - 1]
                                );
                            else
                                maxSum[left, right] = Math.Min(
                                    maxSum[left + 1, right],
                                    maxSum[left, right - 1]
                                );
                        }
                    }

                    isTurn = !isTurn;
                }

                sw.WriteLine(maxSum[0, N - 1]);
            }

            sr.Close();
            sw.Close();
        }
    }
}
