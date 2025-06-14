namespace Algorithm.BOJ.BOJ_19829
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_19829/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr), k = ReadInt(sr);

            int prevA = 0;
            int cnt = 0;
            int maxCnt = 1;

            for (int _ = 0; _ < n; _++)
            {
                int a = ReadInt(sr);
                cnt = a != prevA ? cnt + 1 : 1;
                maxCnt = Math.Max(maxCnt, cnt);
                prevA = a;
            }

            sw.WriteLine(maxCnt);

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
