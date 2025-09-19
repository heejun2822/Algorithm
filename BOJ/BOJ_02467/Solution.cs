namespace Algorithm.BOJ.BOJ_02467
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02467/input1.txt",
            "BOJ/BOJ_02467/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int[] values = new int[N];

            for (int i = 0; i < N; i++)
                values[i] = ReadInt(sr);

            int optSum = int.MaxValue;
            int optVal1 = 0, optVal2 = 0;
            int l = 0, r = N - 1;

            while (l < r)
            {
                int sum = values[l] + values[r];
                int absSum = Math.Abs(sum);
                if (absSum < optSum)
                {
                    optSum = absSum;
                    optVal1 = values[l];
                    optVal2 = values[r];
                }
                if (sum > 0)
                    r--;
                else if (sum < 0)
                    l++;
                else
                    break;
            }

            sw.WriteLine($"{optVal1} {optVal2}");

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
