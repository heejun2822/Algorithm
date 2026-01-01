namespace Algorithm.BOJ.BOJ_01778
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01778/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int caseNum = 1;
            int[] root;
            System.Text.StringBuilder output = new();

            while (true)
            {
                int n = ReadInt(sr), m = ReadInt(sr);

                if (n == 0 && m == 0) break;

                root = new int[n + 1];
                int cnt = n;

                for (int _ = 0; _ < m; _++)
                {
                    int i = ReadInt(sr), j = ReadInt(sr);
                    if (Union(i, j))
                        cnt--;
                }

                output.AppendLine($"Case {caseNum++}: {cnt}");
            }

            sw.Write(output);

            sr.Close();
            sw.Close();

            bool Union(int a, int b)
            {
                a = Find(a);
                b = Find(b);

                if (a == b)
                    return false;

                if (a < b)
                    root[b] = a;
                else
                    root[a] = b;

                return true;
            }

            int Find(int a)
            {
                return root[a] == 0 ? a : (root[a] = Find(root[a]));
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
