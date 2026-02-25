namespace Algorithm.BOJ.BOJ_23917
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_23917/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = ReadInt(sr);

            for (int x = 1; x <= T; x++)
            {
                int N = ReadInt(sr), X = ReadInt(sr);
                (int cnt, int idx)[] people = new (int, int)[N];

                for (int i = 0; i < N; i++)
                {
                    int A = ReadInt(sr);
                    int cnt = (A - 1) / X + 1;
                    people[i] = (cnt, i + 1);
                }

                Array.Sort(people);

                System.Text.StringBuilder y = new();

                for (int i = 0; i < N; i++)
                    y.Append(people[i].idx).Append(' ');

                sw.WriteLine($"Case #{x}: {y}");
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
