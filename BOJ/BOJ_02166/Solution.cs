namespace Algorithm.BOJ.BOJ_02166
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02166/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            double area = 0;
            int fx = ReadInt(sr);
            int fy = ReadInt(sr);
            int x = fx;
            int y = fy;

            for (int _ = 1; _ < N; _++)
            {
                int nx = ReadInt(sr);
                int ny = ReadInt(sr);

                area += (nx - x) * ((ny + y) / 2.0);
                x = nx;
                y = ny;
            }
            area += (fx - x) * ((fy + y) / 2.0);

            sw.WriteLine(Math.Abs(area).ToString("F1"));

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
