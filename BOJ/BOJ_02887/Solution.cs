namespace Algorithm.BOJ.BOJ_02887
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02887/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            (int value, int idx)[] xArr = new (int, int)[N];
            (int value, int idx)[] yArr = new (int, int)[N];
            (int value, int idx)[] zArr = new (int, int)[N];

            for (int i = 0; i < N; i++)
            {
                xArr[i] = (ReadInt(sr), i);
                yArr[i] = (ReadInt(sr), i);
                zArr[i] = (ReadInt(sr), i);
            }

            Array.Sort(xArr, (a, b) => a.value - b.value);
            Array.Sort(yArr, (a, b) => a.value - b.value);
            Array.Sort(zArr, (a, b) => a.value - b.value);

            (int A, int B, int cost)[] tunnels = new (int, int, int)[3 * (N - 1)];

            for (int i = 1; i < N; i++)
            {
                tunnels[3 * i - 3] = (xArr[i - 1].idx, xArr[i].idx, xArr[i].value - xArr[i - 1].value);
                tunnels[3 * i - 2] = (yArr[i - 1].idx, yArr[i].idx, yArr[i].value - yArr[i - 1].value);
                tunnels[3 * i - 1] = (zArr[i - 1].idx, zArr[i].idx, zArr[i].value - zArr[i - 1].value);
            }

            Array.Sort(tunnels, (a, b) => a.cost - b.cost);

            int[] root = new int[N];
            Array.Fill(root, -1);

            long minCost = 0;

            foreach ((int A, int B, int cost) in tunnels)
                if (Union(A, B))
                    minCost += cost;

            sw.WriteLine(minCost);

            sr.Close();
            sw.Close();

            bool Union(int a, int b)
            {
                a = Find(a);
                b = Find(b);

                if (a == b) return false;

                if (a < b)
                    root[b] = a;
                else
                    root[a] = b;

                return true;
            }

            int Find(int a)
            {
                return root[a] == -1 ? a : (root[a] = Find(root[a]));
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
