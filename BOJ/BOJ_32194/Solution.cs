namespace Algorithm.BOJ.BOJ_32194
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_32194/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            int[] accYesCounts = new int[N + 2];
            accYesCounts[0] = 0;
            accYesCounts[1] = 1;

            System.Text.StringBuilder output = new();

            for (int i = 2; i < N + 2; i++)
            {
                int q = ReadInt(sr), x = ReadInt(sr), y = ReadInt(sr);

                int yesCnt = accYesCounts[y] - accYesCounts[x - 1];

                if ((q == 1 && yesCnt == y - x + 1) || (q == 2 && yesCnt == 0))
                {
                    accYesCounts[i] = accYesCounts[i - 1] + 1;
                    output.AppendLine("Yes");
                }
                else
                {
                    accYesCounts[i] = accYesCounts[i - 1];
                    output.AppendLine("No");
                }
            }

            sw.Write(output);

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
