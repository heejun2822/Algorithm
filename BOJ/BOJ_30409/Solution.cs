namespace Algorithm.BOJ.BOJ_30409
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30409/input1.txt",
            "BOJ/BOJ_30409/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int[] H = new int[N + 1];

            for (int i = 1; i <= N; i++)
                H[i] = ReadInt(sr);

            long[] minCost = new long[N + 1];

            Stack<(int idx, long cost)> stack = new();
            long totalCost = 0;
            for (int i = 1; i <= N; i++)
                minCost[i] += UpdateCost(i);

            stack.Clear();
            totalCost = 0;
            for (int i = N; i >= 1; i--)
                minCost[i] += UpdateCost(i);

            int Q = ReadInt(sr);

            while (Q-- > 0)
            {
                int p = ReadInt(sr);
                sw.WriteLine(minCost[p]);
            }

            sr.Close();
            sw.Close();

            long UpdateCost(int idx)
            {
                (int idx, long cost) ele;

                while (stack.TryPeek(out ele) && H[ele.idx] < H[idx])
                {
                    stack.Pop();
                    totalCost -= ele.cost;
                }

                long dx = 0, dy = 0;
                if (stack.TryPeek(out ele))
                {
                    dx = idx - ele.idx;
                    dy = H[idx] - H[ele.idx];
                }
                long cost = dx * dx + dy * dy;

                stack.Push((idx, cost));
                totalCost += cost;

                return totalCost;
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
