namespace Algorithm.BOJ.BOJ_26006
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_26006/input1.txt",
            "BOJ/BOJ_26006/input2.txt",
            "BOJ/BOJ_26006/input3.txt",
            "BOJ/BOJ_26006/input4.txt",
            "BOJ/BOJ_26006/input5.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), K = ReadInt(sr);

            (int R, int C) king = (ReadInt(sr), ReadInt(sr));
            List<(int R, int C)> cells = new(9);

            for (int r = -1; r <= 1; r++)
            {
                for (int c = -1; c <= 1; c++)
                {
                    int ar = king.R + r, ac = king.C + c;
                    if (ar < 1 || ar > N || ac < 1 || ac > N) continue;
                    cells.Add((ar, ac));
                }
            }

            while (K-- > 0)
            {
                int R = ReadInt(sr), C = ReadInt(sr);

                for (int i = cells.Count - 1; i >= 0; i--)
                    if (cells[i].R == R || cells[i].C == C || cells[i].R - cells[i].C == R - C || cells[i].R + cells[i].C == R + C)
                        cells.Remove(cells[i]);

                if (cells.Count == 0) break;
            }

            string state = "NONE";
            if (cells.Count == 0)
                state = "CHECKMATE";
            else if (cells.Count == 1 && cells[0] == king)
                state = "STALEMATE";
            else if (!cells.Contains(king))
                state = "CHECK";

            sw.WriteLine(state);

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
