namespace Algorithm.BOJ.BOJ_17093
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17093/input1.txt",
            "BOJ/BOJ_17093/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nm = sr.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            (int x, int y)[] P = new (int, int)[N];
            for (int i = 0; i < N; i++)
            {
                string[] xy = sr.ReadLine()!.Split();
                P[i] = (int.Parse(xy[0]), int.Parse(xy[1]));
            }

            long maxRS = 0;

            for (int i = 0; i < M; i++)
            {
                string[] xy = sr.ReadLine()!.Split();
                long Qix = long.Parse(xy[0]);
                long Qiy = long.Parse(xy[1]);

                for (int j = 0; j < N; j++)
                    maxRS = Math.Max(maxRS, (Qix - P[j].x) * (Qix - P[j].x) + (Qiy - P[j].y) * (Qiy - P[j].y));
            }

            sw.WriteLine(maxRS);

            sr.Close();
            sw.Close();
        }
    }
}
