namespace Algorithm.BOJ.BOJ_14170
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14170/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), Q = ReadInt(sr);
            int[] locations = new int[N];

            for (int i = 0; i < N; i++)
                locations[i] = ReadInt(sr);
            Array.Sort(locations);

            System.Text.StringBuilder output = new();

            for (int _ = 0; _ < Q; _++)
            {
                int A = ReadInt(sr), B = ReadInt(sr);

                if (A > locations[N - 1] || B < locations[0])
                {
                    output.AppendLine("0");
                    continue;
                }

                int l = 0, r = N - 1;
                while (l < r)
                {
                    int m = (l + r) / 2;
                    if (locations[m] < A)
                        l = m + 1;
                    else if (locations[m] > A)
                        r = m;
                    else
                        l = r = m;
                }
                int idxA = r;

                l = 0; r = N - 1;
                while (l < r)
                {
                    int m = (l + r + 1) / 2;
                    if (locations[m] < B)
                        l = m;
                    else if (locations[m] > B)
                        r = m - 1;
                    else
                        l = r = m;
                }
                int idxB = l;

                output.AppendLine((idxB - idxA + 1).ToString());
            }

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
