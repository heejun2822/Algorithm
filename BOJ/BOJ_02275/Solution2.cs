namespace Algorithm.BOJ.BOJ_02275
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02275/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), H = ReadInt(sr);

            int[] parents = new int[N + 1];
            int[] weights = new int[N + 1];
            int root = 0;

            for (int i = 1; i <= N; i++)
            {
                parents[i] = ReadInt(sr);
                weights[i] = ReadInt(sr);
                if (parents[i] == 0)
                    root = i;
            }

            bool[] isValid = new bool[N + 1];
            int minCost = 0;

            for (int i = 1; i <= N; i++)
            {
                if (isValid[i]) continue;
                ValidateNode(i, 0);
            }

            sw.WriteLine(minCost);

            sr.Close();
            sw.Close();

            int ValidateNode(int node, int height)
            {
                if (node == root) return height;

                height = ValidateNode(parents[node], height + weights[node]);

                int cost = Math.Clamp(height - H, 0, weights[node]);
                weights[node] -= cost;
                minCost += cost;
                isValid[node] = true;

                return height - cost;
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
