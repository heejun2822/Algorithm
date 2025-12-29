namespace Algorithm.BOJ.BOJ_19584
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_19584/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr);

            (int idx, int y)[] places = new (int, int)[N];

            for (int i = 0; i < N; i++)
            {
                int x = ReadInt(sr), y = ReadInt(sr);
                places[i] = (i, y);
            }

            Array.Sort(places, (a, b) => a.y - b.y);

            int compressedY = 0;
            int prevY = places[0].y;

            for (int i = 0; i < N; i++)
            {
                if (places[i].y > prevY)
                    compressedY++;
                prevY = places[i].y;
                places[i].y = compressedY;
            }

            Array.Sort(places, (a, b) => a.idx - b.idx);

            long[] diffC = new long[compressedY + 2];

            for (int _ = 0; _ < M; _++)
            {
                int u = ReadInt(sr), v = ReadInt(sr), c = ReadInt(sr);

                int y1 = places[u - 1].y, y2 = places[v - 1].y;
                (y1, y2) = y1 < y2 ? (y1, y2) : (y2, y1);

                diffC[y1] += c;
                diffC[y2 + 1] -= c;
            }

            long accC = 0;
            long maxC = 0;

            for (int y = 0; y <= compressedY; y++)
                maxC = Math.Max(maxC, accC += diffC[y]);

            sw.WriteLine(maxC);

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
