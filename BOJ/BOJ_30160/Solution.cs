namespace Algorithm.BOJ.BOJ_30160
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30160/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            int[] accSum = new int[N + 1];

            for (int i = 1; i <= N; i++)
                accSum[i] = accSum[i - 1] + ReadInt(sr);

            System.Text.StringBuilder output = new();
            long value = 0;
            long delta = 0;

            for (int i = 1; i <= N; i++)
                output.Append(value += delta += accSum[i - 1] + accSum[i]).Append(' ');

            sw.WriteLine(output);

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
