namespace Algorithm.BOJ.BOJ_19805
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_19805/input1.txt",
            "BOJ/BOJ_19805/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr);

            int sum = 0;
            int min = 1000;

            for (int _ = 0; _ < n; _++)
            {
                int a = ReadInt(sr);
                if (a % 2 == 0) a--;
                sum += a;
                min = Math.Min(min, a);
            }

            sw.WriteLine(n % 2 == 1 ? sum : sum - min);

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
