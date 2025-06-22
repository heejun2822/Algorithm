namespace Algorithm.BOJ.BOJ_25426
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_25426/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            int[] aFactors = new int[N];
            long sum = 0;

            for (int i = 0; i < N; i++)
            {
                int a = ReadInt(sr), b = ReadInt(sr);
                aFactors[i] = a;
                sum += b;
            }

            Array.Sort(aFactors);

            for (long x = 1; x <= N; x++)
                sum += aFactors[x - 1] * x;

            sw.WriteLine(sum);

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
