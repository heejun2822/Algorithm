namespace Algorithm.BOJ.BOJ_27496
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_27496/input1.txt",
            "BOJ/BOJ_27496/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int L = ReadInt(sr);

            int[] accA = new int[N + L];

            for (int i = 0; i < N; i++)
                accA[L + i] = accA[L + i - 1] + ReadInt(sr);

            int time = 0;

            for (int i = 0; i < N; i++)
            {
                int C = accA[L + i] - accA[i];
                if (C >= 129 && C <= 138) time++;
            }

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
