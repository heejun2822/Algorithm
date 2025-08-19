namespace Algorithm.BOJ.BOJ_10899
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10899/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int P = ReadInt(sr), N = ReadInt(sr);
            int[] times = new int[N];

            for (int i = 0; i < N; i++)
                times[i] = ReadInt(sr);

            Array.Sort(times);

            int penalty = P - 1;
            int cnt = 0;
            long totalPenalty = 0;

            for (int i = 0; i < N; i++)
            {
                if (penalty - times[i] >= 0)
                {
                    cnt++;
                    totalPenalty += penalty;
                    penalty -= times[i];
                }
                else
                    break;
            }

            sw.WriteLine($"{cnt} {totalPenalty}");

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
