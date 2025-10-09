namespace Algorithm.BOJ.BOJ_28324
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_28324/input1.txt",
            "BOJ/BOJ_28324/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int[] V = new int[N];

            for (int i = 0; i < N; i++)
                V[i] = ReadInt(sr);

            long result = 0;
            int speed = 0;

            for (int i = N - 1; i >= 0; i--)
            {
                speed = Math.Min(speed + 1, V[i]);
                result += speed;
            }

            sw.WriteLine(result);

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
