namespace Algorithm.BOJ.BOJ_27206
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_27206/input1.txt",
            "BOJ/BOJ_27206/input2.txt",
            "BOJ/BOJ_27206/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            (int A, int B)[] times = new (int, int)[N];

            for (int i = 0; i < N; i++)
                times[i] = (ReadInt(sr), ReadInt(sr));

            Array.Sort(times, (a, b) => b.B - a.B);

            int minTimeOfOnePair = times[0].A + times[0].B;
            int minTimeOfTwoPair = int.MaxValue;
            int minRecord = int.MaxValue;

            for (int i = 1; i < N - 1; i++)
            {
                minTimeOfTwoPair = Math.Min(minTimeOfTwoPair, minTimeOfOnePair + times[i].A + times[i].B);
                minRecord = Math.Min(minRecord, minTimeOfTwoPair + times[i + 1].A);
                minTimeOfOnePair = Math.Min(minTimeOfOnePair, times[i].A + times[i].B);
            }

            sw.WriteLine(minRecord);

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
