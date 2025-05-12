namespace Algorithm.BOJ.BOJ_17095
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_17095/input1.txt",
            "BOJ/BOJ_17095/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            int max = 0, min = 100_001;
            int maxIdx = -1, minIdx = -1;
            int minLen = 1;

            for (int i = 0; i < N; i++)
            {
                int A_i = ReadInt(sr);

                if (A_i > max)
                {
                    max = A_i;
                    maxIdx = i;
                    minLen = maxIdx - minIdx + 1;
                }
                else if (A_i == max)
                {
                    maxIdx = i;
                    minLen = Math.Min(minLen, maxIdx - minIdx + 1);
                }

                if (A_i < min)
                {
                    min = A_i;
                    minIdx = i;
                    minLen = minIdx - maxIdx + 1;
                }
                else if (A_i == min)
                {
                    minIdx = i;
                    minLen = Math.Min(minLen, minIdx - maxIdx + 1);
                }
            }

            sw.WriteLine(minLen);

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
