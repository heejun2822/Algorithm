namespace Algorithm.BOJ.BOJ_33900
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_33900/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr), R = ReadInt(sr), C = ReadInt(sr);
            int[,] map = new int[N, M];
            int[,] workMap = new int[R, C];

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    map[i, j] = ReadInt(sr);

            for (int i = 0; i < R; i++)
                for (int j = 0; j < C; j++)
                    workMap[i, j] = ReadInt(sr);

            int cnt = 0;

            for (int i = 0; i < N - R + 1; i++)
                for (int j = 0; j < M - C + 1; j++)
                    if (IsFlat(i, j))
                        cnt++;

            sw.WriteLine(cnt);

            sr.Close();
            sw.Close();

            bool IsFlat(int i, int j)
            {
                int height = map[i, j] - workMap[0, 0];

                for (int x = 0; x < R; x++)
                    for (int y = 0; y < C; y++)
                        if (map[i + x, j + y] - workMap[x, y] != height)
                            return false;
                return true;
            }
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
