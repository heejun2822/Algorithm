namespace Algorithm.BOJ.BOJ_12383
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12383/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = ReadInt(sr);

            List<int>[] childrenList;
            int[] lastVisited;

            for (int x = 1; x <= T; x++)
            {
                int N = ReadInt(sr);

                childrenList = new List<int>[N + 1];

                for (int i = 1; i <= N; i++)
                    childrenList[i] = new();

                for (int i = 1; i <= N; i++)
                {
                    int M = ReadInt(sr);
                    while (M-- > 0)
                        childrenList[ReadInt(sr)].Add(i);
                }

                lastVisited = new int[N + 1];

                string y = "No";

                for (int i = 1; i <= N; i++)
                {
                    if (lastVisited[i] == 0 && childrenList[i].Count >= 2 && ContainsDiamondInheritance(i, i))
                    {
                        y = "Yes";
                        break;
                    }
                }

                sw.WriteLine($"Case #{x}: {y}");
            }

            sr.Close();
            sw.Close();

            bool ContainsDiamondInheritance(int root, int node)
            {
                if (lastVisited[node] == root)
                    return true;

                lastVisited[node] = root;

                foreach (int child in childrenList[node])
                    if (ContainsDiamondInheritance(root, child))
                        return true;

                return false;
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
