namespace Algorithm.BOJ.BOJ_04183
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04183/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int tc = ReadInt(sr);

            while (tc-- > 0)
            {
                int n = ReadInt(sr);

                int[] numbers = new int[n];
                HashSet<int> set = new();
                int l = 0;
                int maxCnt = 0;

                for (int r = 0; r < n; r++)
                {
                    numbers[r] = ReadInt(sr);

                    if (set.Contains(numbers[r]))
                    {
                        while (true)
                        {
                            set.Remove(numbers[l]);
                            if (numbers[l++] == numbers[r]) break;
                        }
                    }
                    set.Add(numbers[r]);

                    maxCnt = Math.Max(maxCnt, r - l + 1);
                }

                sw.WriteLine(maxCnt);
            }

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
