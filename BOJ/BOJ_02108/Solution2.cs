namespace Algorithm.BOJ.BOJ_02108
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02108/input1.txt",
            "BOJ/BOJ_02108/input2.txt",
            "BOJ/BOJ_02108/input3.txt",
            "BOJ/BOJ_02108/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] counts = new int[8001];
            for (int _ = 0; _ < N; _++) counts[int.Parse(Console.ReadLine()!) + 4000]++;

            int sum = 0;
            int maxCnt = 0;
            int[] mosts = new int[2];
            for (int i = 0; i < 8001; i++)
            {
                if (counts[i] == 0) continue;
                sum += (i - 4000) * counts[i];
                if (counts[i] > maxCnt)
                {
                    maxCnt = counts[i];
                    mosts[0] = i - 4000;
                    mosts[1] = 4001;
                }
                else if (counts[i] == maxCnt)
                {
                    if (mosts[1] == 4001) mosts[1] = i - 4000;
                }
            }

            int totalCnt = 0;
            int mid = 0;
            for (int i = 0; i < 8001; i++)
            {
                if (counts[i] == 0) continue;
                if ((totalCnt += counts[i]) > N / 2) { mid = i - 4000; break; }
            }

            int min = 0;
            for (int i = 0; i < 8001; i++) if (counts[i] > 0) { min = i - 4000; break; }

            int max = 0;
            for (int i = 8000; i >= 0; i--) if (counts[i] > 0) { max = i - 4000; break; }

            Console.WriteLine((int)Math.Round((double)sum / N));
            Console.WriteLine(mid);
            Console.WriteLine(mosts[1] == 4001 ? mosts[0] : mosts[1]);
            Console.WriteLine(max - min);
        }
    }
}
