namespace Algorithm.BOJ.BOJ_17931
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17931/input1.txt",
            "BOJ/BOJ_17931/input2.txt",
            "BOJ/BOJ_17931/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            System.Text.StringBuilder GIS = new();
            int g = 0;
            int l = 0;

            for (int _ = 0; _ < N; _++)
            {
                int a = ReadInt(sr);
                if (a > g)
                {
                    g = a;
                    GIS.Append(g).Append(' ');
                    l++;
                }
            }

            sw.WriteLine(l);
            sw.WriteLine(GIS);

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
