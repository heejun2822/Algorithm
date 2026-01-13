namespace Algorithm.BOJ.BOJ_04029
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04029/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int tc = 1;

            while (true)
            {
                int b = ReadInt(sr), c = ReadInt(sr);

                if (b == 0 && c == 0) break;

                int[,] rankList = new int[b, c];

                for (int i = 0; i < b; i++)
                    for (int r = 1; r <= c; r++)
                        rankList[i, ReadInt(sr)] = r;

                bool[] isWinner = new bool[c];
                Array.Fill(isWinner, true);

                for (int p = 0; p < c; p++)
                {
                    for (int q = p + 1; q < c; q++)
                    {
                        if (!isWinner[p] && !isWinner[q]) continue;

                        int diff = 0;

                        for (int i = 0; i < b; i++)
                            diff += rankList[i, p] < rankList[i, q] ? 1 : -1;

                        if (diff >= 0)
                            isWinner[q] = false;
                        if (diff <= 0)
                            isWinner[p] = false;
                    }
                }

                string winner = "No Condorcet winner";

                for (int i = 0; i < c; i++)
                {
                    if (isWinner[i])
                    {
                        winner = i.ToString();
                        break;
                    }
                }

                sw.WriteLine($"Case {tc++}: {winner}");
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
