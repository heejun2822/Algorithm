namespace Algorithm.BOJ.BOJ_03863
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_03863/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            while (true)
            {
                string[] nm = sr.ReadLine()!.Split();
                int N = int.Parse(nm[0]);
                int M = int.Parse(nm[1]);

                if (N == 0 && M == 0) break;

                (int start, int end)[] calls = new (int, int)[N];
                for (int i = 0; i < N; i++)
                {
                    string[] info = sr.ReadLine()!.Split();
                    int start = int.Parse(info[2]);
                    int duration = int.Parse(info[3]);
                    calls[i] = (start, start + duration);
                }

                for (int _ = 0; _ < M; _++)
                {
                    string[] info = sr.ReadLine()!.Split();
                    int start = int.Parse(info[0]);
                    int end = start + int.Parse(info[1]);

                    int cnt = 0;
                    for (int i = 0; i < N; i++)
                        if (start < calls[i].end && end > calls[i].start) cnt++;

                    sw.WriteLine(cnt);
                }
            }

            sr.Close();
            sw.Close();
        }
    }
}
