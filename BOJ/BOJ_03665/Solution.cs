namespace Algorithm.BOJ.BOJ_03665
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_03665/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int tc = ReadInt(sr);

            for (int _ = 0; _ < tc; _++)
            {
                int n = ReadInt(sr);

                int[] rankings = new int[n + 1];
                (int team, int inDegree)[] inDegrees = new (int, int)[n + 1];

                inDegrees[0] = (0, -1);

                for (int i = 0; i < n; i++)
                {
                    int t = ReadInt(sr);
                    rankings[t] = i;
                    inDegrees[t] = (t, i);
                }

                int m = ReadInt(sr);

                for (int i = 0; i < m; i++)
                {
                    int a = ReadInt(sr), b = ReadInt(sr);

                    if (rankings[a] < rankings[b])
                    {
                        inDegrees[a].inDegree++;
                        inDegrees[b].inDegree--;
                    }
                    else
                    {
                        inDegrees[a].inDegree--;
                        inDegrees[b].inDegree++;
                    }
                }

                Array.Sort(inDegrees, (a, b) => a.inDegree - b.inDegree);

                StringBuilder newRanking = new();

                for (int i = 1; i <= n; i++)
                {
                    if (inDegrees[i].inDegree == i - 1)
                        newRanking.Append(inDegrees[i].team).Append(' ');
                    else
                    {
                        newRanking = new("IMPOSSIBLE");
                        break;
                    }
                }

                sw.WriteLine(newRanking);
            }

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
