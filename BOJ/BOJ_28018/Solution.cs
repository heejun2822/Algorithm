namespace Algorithm.BOJ.BOJ_28018
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_28018/input1.txt",
            "BOJ/BOJ_28018/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int[] diff = new int[1_000_002];
            int[] accSum = new int[1_000_001];

            int N = ReadInt(sr);

            for (int _ = 0; _ < N; _++)
            {
                int S = ReadInt(sr), E = ReadInt(sr);
                diff[S]++;
                diff[E + 1]--;
            }
            for (int i = 1; i <= 1_000_000; i++)
                accSum[i] = accSum[i - 1] + diff[i];

            System.Text.StringBuilder output = new();

            int Q = ReadInt(sr);

            for (int _ = 0; _ < Q; _++)
                output.AppendLine(accSum[ReadInt(sr)].ToString());

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
