namespace Algorithm.BOJ.BOJ_25557
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25557/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            double[,] exp = new double[2401, 2401];

            int N = ReadInt(sr);

            while (N-- > 0)
            {
                int x = ReadInt(sr), y = ReadInt(sr), k = ReadInt(sr);
                sw.WriteLine(GetExp(x, y, k));
            }

            sr.Close();
            sw.Close();

            double GetExp(int a, int b, int k)
            {
                if (exp[k - a, b - k] == 0)
                {
                    int min = Math.Max(a, (int)Math.Ceiling((a + b) / 2.0 - 1));
                    int max = Math.Min(b, (int)Math.Floor((a + b) / 2.0 + 1));

                    double cnt = 0;

                    for (int n = min; n <= max; n++)
                    {
                        if (n < k)
                            cnt += 1 + GetExp(n + 1, b, k);
                        else if (n > k)
                            cnt += 1 + GetExp(a, n - 1, k);
                        else
                            cnt += 1;
                    }

                    exp[k - a, b - k] = cnt / (max - min + 1);
                }

                return exp[k - a, b - k];
            }
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
