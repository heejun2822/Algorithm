namespace Algorithm.BOJ.BOJ_35212
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_35212/input1.txt",
            "BOJ/BOJ_35212/input2.txt",
            "BOJ/BOJ_35212/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr);
            double w = ReadInt(sr);

            (int p, int t)[] mills = new (int, int)[n];

            for (int i = 0; i < n; i++)
                mills[i] = (ReadInt(sr), ReadInt(sr));

            Array.Sort(mills, (a, b) => a.t - b.t);

            int idx = 0;
            long totalP = 0;
            double time = mills[0].t * 2;

            while (idx < n && w > 0)
            {
                int currT = mills[idx].t;

                while (idx < n && mills[idx].t == currT)
                    totalP += mills[idx++].p;

                double dt = w / totalP;
                if (idx < n)
                    dt = Math.Min(dt, (mills[idx].t - currT) * 2);

                w -= totalP * dt;
                time += dt;
            }

            sw.WriteLine(time);

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
