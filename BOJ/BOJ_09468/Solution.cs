namespace Algorithm.BOJ.BOJ_09468
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09468/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int P = ReadInt(sr);

            System.Text.StringBuilder output = new();

            for (int _ = 0; _ < P; _++)
            {
                int K = ReadInt(sr);

                int a = 0;
                int cnt = 0;

                for (int i = 0; i < 15; i++)
                {
                    int nextA = ReadInt(sr);

                    if (nextA > a) cnt++;
                    a = nextA;
                }

                output.AppendLine($"{K} {cnt}");
            }

            sw.Write(output);

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
