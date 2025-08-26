namespace Algorithm.BOJ.BOJ_25511
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25511/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr);
            int k = ReadInt(sr);

            int[] parents = new int[n];

            for (int _ = 0; _ < n - 1; _++)
            {
                int p = ReadInt(sr), c = ReadInt(sr);
                parents[c] = p;
            }

            int node = 0;

            for (int i = 0; i < n; i++)
            {
                int value = ReadInt(sr);
                if (value == k)
                {
                    node = i;
                    break;
                }
            }

            int depth = 0;

            while (node != 0)
            {
                node = parents[node];
                depth++;
            }

            sw.WriteLine(depth);

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
