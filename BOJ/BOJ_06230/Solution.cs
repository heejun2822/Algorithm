namespace Algorithm.BOJ.BOJ_06230
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06230/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nm = sr.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            int[] highQualityBales = new int[N];
            int[] lowQualityBales = new int[M];

            for (int i = 0; i < N; i++) highQualityBales[i] = int.Parse(sr.ReadLine()!);
            for (int i = 0; i < M; i++) lowQualityBales[i] = int.Parse(sr.ReadLine()!);

            Array.Sort(highQualityBales);
            Array.Sort(lowQualityBales);

            int maxBalesCnt = N;
            int idxL = 0;
            for (int idxH = 0; idxH < N; idxH++)
            {
                if (lowQualityBales[idxL] < highQualityBales[idxH])
                {
                    maxBalesCnt++;
                    if (++idxL == M) break;
                }
            }

            sw.WriteLine(maxBalesCnt);

            sr.Close();
            sw.Close();
        }
    }
}
