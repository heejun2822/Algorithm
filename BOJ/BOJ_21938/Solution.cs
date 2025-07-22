namespace Algorithm.BOJ.BOJ_21938
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_21938/input1.txt",
            "BOJ/BOJ_21938/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr);
            int[,] pixels = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    int R = ReadInt(sr), G = ReadInt(sr), B = ReadInt(sr);
                    pixels[i, j] = (R + G + B) / 3;
                }
            }

            int T = ReadInt(sr);
            bool[,] visited = new bool[N, M];
            int cnt = 0;

            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    if (SearchObject(i, j))
                        cnt++;

            sw.WriteLine(cnt);

            sr.Close();
            sw.Close();

            bool SearchObject(int i, int j)
            {
                if (visited[i, j]) return false;

                visited[i, j] = true;

                if (pixels[i, j] < T) return false;

                if (i - 1 >= 0) SearchObject(i - 1, j);
                if (i + 1 < N) SearchObject(i + 1, j);
                if (j - 1 >= 0) SearchObject(i, j - 1);
                if (j + 1 < M) SearchObject(i, j + 1);

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
