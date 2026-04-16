namespace Algorithm.BOJ.BOJ_09818
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09818/input.txt",
        ];

        public static void Run(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()!) != "-1")
            {
                string[] splited = input.Split(',');
                int n = int.Parse(splited[0]), m = int.Parse(splited[1]), k = int.Parse(splited[2]);

                int[] miceCnt = new int[n + 1];
                miceCnt[1] = 1;

                for (int _ = 2; _ <= k; _++)
                {
                    int prevMiceCnt = 0;

                    for (int i = n; i >= 1; i--)
                    {
                        miceCnt[i] = miceCnt[i - 1];
                        prevMiceCnt += miceCnt[i];
                    }

                    if (prevMiceCnt <= 100)
                    {
                        miceCnt[1] += miceCnt[7] + miceCnt[8];
                        for (int i = 0; i < m; i++)
                            miceCnt[1] += miceCnt[9 + i] * 2;
                    }
                }

                Console.WriteLine($"{input}: {miceCnt.Sum()}");
            }
        }
    }
}
