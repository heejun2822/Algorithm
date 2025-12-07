namespace Algorithm.BOJ.BOJ_24391
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_24391/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr);

            int[] roots = new int[N + 1];

            for (int _ = 0; _ < M; _++)
            {
                int i = ReadInt(sr), j = ReadInt(sr);
                Union(i, j);
            }

            int cnt = 0;
            int prevA = ReadInt(sr);

            for (int _ = 1; _ < N; _++)
            {
                int A = ReadInt(sr);
                if (Find(prevA) != Find(A))
                    cnt++;
                prevA = A;
            }

            sw.WriteLine(cnt);

            sr.Close();
            sw.Close();

            void Union(int a, int b)
            {
                a = Find(a);
                b = Find(b);

                if (a == b) return;

                if (a < b)
                    roots[b] = a;
                else
                    roots[a] = b;
            }

            int Find(int a)
            {
                return roots[a] == 0 ? a : (roots[a] = Find(roots[a]));
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
