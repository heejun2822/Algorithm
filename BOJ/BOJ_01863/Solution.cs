namespace Algorithm.BOJ.BOJ_01863
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01863/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr);

            Stack<int> stack = new();
            stack.Push(0);

            int cnt = 0;

            for (int _ = 0; _ < n; _++)
            {
                int x = ReadInt(sr), y = ReadInt(sr);

                while (y < stack.Peek())
                {
                    stack.Pop();
                    cnt++;
                }
                if (y > stack.Peek())
                    stack.Push(y);
            }

            cnt += stack.Count - 1;

            sw.WriteLine(cnt);

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
