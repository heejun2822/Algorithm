namespace Algorithm.BOJ.BOJ_32608
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_32608/input1.txt",
            "BOJ/BOJ_32608/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr), h = ReadInt(sr);

            double time = 0;

            int size = ReadInt(sr), distance = ReadInt(sr);
            double v = Math.Cbrt(Math.Sqrt(size * 1e-9)) * 1e3;

            for (int _ = 1; _ < n; _++)
            {
                int s = ReadInt(sr), y = ReadInt(sr);

                time += (y - distance) / v;

                size += s;
                distance = y;
                v = Math.Cbrt(Math.Sqrt(size * 1e-9)) * 1e3;
            }

            time += (h - distance) / v;

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
