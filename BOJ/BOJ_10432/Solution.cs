namespace Algorithm.BOJ.BOJ_10432
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10432/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int P = ReadInt(sr);

            Stack<int> islands = new();
            islands.Push(0);

            System.Text.StringBuilder output = new();

            while (P-- > 0)
            {
                int T = ReadInt(sr);
                int cnt = 0;

                for (int _ = 0; _ < 12; _++)
                {
                    int a = ReadInt(sr);

                    while (a < islands.Peek())
                    {
                        islands.Pop();
                        cnt++;
                    }

                    if (a > islands.Peek())
                        islands.Push(a);
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
