namespace Algorithm.BOJ.BOJ_34225
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_34225/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            (int idx, int A)[] modules = new (int, int)[N];

            for (int i = 0; i < N; i++)
                modules[i] = (i + 1, ReadInt(sr));

            Array.Sort(modules, (a, b) => b.A - a.A);

            long score = modules[0].A * 3L;
            long maxScore = score;
            int maxCnt = 1;

            for (int i = 1; i < N; i++)
            {
                score += modules[i].A * 2 - modules[i - 1].A;
                if (score > maxScore)
                {
                    maxScore = score;
                    maxCnt = i + 1;
                }
            }

            System.Text.StringBuilder output = new();

            output.AppendLine(maxCnt.ToString());
            for (int i = 0; i < maxCnt; i++)
                output.Append(modules[i].idx).Append(' ');

            sw.WriteLine(output);

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
