namespace Algorithm.BOJ.BOJ_07983
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_07983/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr);
            (int d, int t)[] assignments = new (int, int)[n];

            for (int i = 0; i < n; i++)
                assignments[i] = (ReadInt(sr), ReadInt(sr));

            Array.Sort(assignments, (a, b) => b.t - a.t);

            int day = int.MaxValue;

            for (int i = 0; i < n; i++)
                day = Math.Min(day, assignments[i].t) - assignments[i].d;

            sw.WriteLine(day);

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
