namespace Algorithm.BOJ.BOJ_17371
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17371/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            (int x, int y)[] pos = new (int, int)[N];
            int[] maxSqrDist = new int[N];

            for (int i = 0; i < N; i++)
            {
                pos[i] = (ReadInt(sr), ReadInt(sr));

                for (int j = 0; j < i; j++)
                {
                    int dx = pos[i].x - pos[j].x;
                    int dy = pos[i].y - pos[j].y;
                    int sqrDist = dx * dx + dy * dy;
                    maxSqrDist[i] = Math.Max(maxSqrDist[i], sqrDist);
                    maxSqrDist[j] = Math.Max(maxSqrDist[j], sqrDist);
                }
            }

            int t = 0;

            for (int i = 1; i < N; i++)
                if (maxSqrDist[i] < maxSqrDist[t])
                    t = i;

            sw.WriteLine($"{pos[t].x} {pos[t].y}");

            sr.Close();
            sw.Close();
        }

        private static int ReadInt(StreamReader sr)
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { sr.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
