namespace Algorithm.BOJ.BOJ_05176
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_05176/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int K = ReadInt(sr);

            for (int _ = 0; _ < K; _++)
            {
                int P = ReadInt(sr), M = ReadInt(sr);

                bool[] isFull = new bool[M + 1];
                int cnt = 0;

                for (int i = 0; i < P; i++)
                {
                    int seat = ReadInt(sr);
                    if (isFull[seat]) cnt++;
                    else isFull[seat] = true;
                }

                sw.WriteLine(cnt);
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
