namespace Algorithm.BOJ.BOJ_20153
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20153/input1.txt",
            "BOJ/BOJ_20153/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int[] A = new int[N];
            int totalA = 0;

            for (int i = 0; i < N; i++)
                totalA ^= A[i] = ReadInt(sr);

            int max = totalA;

            for (int i = 0; i < N; i++)
                max = Math.Max(max, totalA ^ A[i]);

            sw.WriteLine($"{max}{max}");

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
