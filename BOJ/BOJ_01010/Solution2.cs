namespace Algorithm.BOJ.BOJ_01010
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01010/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int T = int.Parse(sr.ReadLine()!);
            for (int _ = 0; _ < T; _++)
            {
                string[] nm = sr.ReadLine()!.Split();
                int N = int.Parse(nm[0]);
                int M = int.Parse(nm[1]);

                // 조합의 수 (Number of Combinations)
                N = Math.Min(N, M - N);
                int res = 1;
                for (int i = 0; i < N; i++) res = res * (M - i) / (i + 1);
                sw.WriteLine(res);
            }

            sr.Close();
            sw.Close();
        }
    }
}
