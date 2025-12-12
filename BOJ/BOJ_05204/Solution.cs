namespace Algorithm.BOJ.BOJ_05204
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05204/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int K = ReadInt(sr);

            HashSet<int> assignments;
            int[,] friendMusics;

            for (int x = 1; x <= K; x++)
            {
                int s = ReadInt(sr), m = ReadInt(sr), n = ReadInt(sr);
                assignments = new(s);
                friendMusics = new int[n, m];

                for (int i = 0; i < n; i++)
                    for (int j = 0; j < m; j++)
                        friendMusics[i, j] = ReadInt(sr);

                int maxCnt = 0;
                Combination(m, s, ref maxCnt);

                sw.WriteLine($"Data Set {x}:\n{maxCnt}");
            }

            sr.Close();
            sw.Close();

            void Combination(int m, int s, ref int maxCnt)
            {
                if (s == 0)
                {
                    maxCnt = Math.Max(maxCnt, CountFriends());
                    return;
                }

                if (m < s) return;

                assignments.Add(m);
                Combination(m - 1, s - 1, ref maxCnt);
                assignments.Remove(m);
                Combination(m - 1, s, ref maxCnt);
            }

            int CountFriends()
            {
                int n = friendMusics.GetLength(0);
                int m = friendMusics.GetLength(1);

                int cnt = 1;
                int myMusic = 0;

                for (int i = 0; i < m; i++)
                {
                    if (assignments.Contains(friendMusics[0, i]))
                    {
                        myMusic = friendMusics[0, i];
                        break;
                    }
                }

                for (int f = 1; f < n; f++)
                {
                    for (int i = 0; i < m; i++)
                    {
                        if (assignments.Contains(friendMusics[f, i]))
                        {
                            if (friendMusics[f, i] == myMusic)
                                cnt++;
                            break;
                        }
                    }
                }

                return cnt;
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
