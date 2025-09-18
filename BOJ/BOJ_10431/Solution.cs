namespace Algorithm.BOJ.BOJ_10431
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10431/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int P = ReadInt(sr);

            System.Text.StringBuilder output = new();

            while (P-- > 0)
            {
                int T = ReadInt(sr);

                int[] heights = new int[20];
                int cnt = 0;

                for (int i = 0; i < 20; i++)
                {
                    int h = ReadInt(sr);
                    int idx = i;

                    for (int j = 0; j < i; j++)
                    {
                        if (heights[j] > h)
                        {
                            idx = j;
                            break;
                        }
                    }

                    for (int j = i; j > idx; j--)
                    {
                        heights[j] = heights[j - 1];
                        cnt++;
                    }
                    heights[idx] = h;
                }

                output.AppendLine($"{T} {cnt}");
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
