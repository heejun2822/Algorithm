namespace Algorithm.BOJ.BOJ_09048
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09048/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = ReadInt(sr);

            while (T-- > 0)
            {
                int F = ReadInt(sr), R = ReadInt(sr), N = ReadInt(sr);

                bool[,] offices = new bool[F, R];

                for (int _ = 0; _ < N; _++)
                {
                    int a = ReadInt(sr), b = ReadInt(sr);
                    offices[a - 1, b - 1] = true;
                }

                int distance = 2 * F + R + 1;

                for (int i = 0; i < F; i++)
                {
                    int gap = 0;
                    int maxGap = 0;

                    for (int j = 0; j < R; j++)
                    {
                        if (offices[i, j])
                            gap = 0;
                        else
                            maxGap = Math.Max(maxGap, ++gap);
                    }

                    distance += (R - maxGap) * 2;
                }

                sw.WriteLine(distance);
            }

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
