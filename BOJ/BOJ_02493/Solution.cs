namespace Algorithm.BOJ.BOJ_02493
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02493/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            Stack<(int idx, int h)> hStack = new();
            System.Text.StringBuilder output = new();

            for (int i = 1; i <= N; i++)
            {
                int h = ReadInt(sr);

                while (hStack.Count > 0 && hStack.Peek().h < h)
                    hStack.Pop();

                output.Append(hStack.Count > 0 ? hStack.Peek().idx : 0).Append(' ');

                hStack.Push((i, h));
            }

            sw.WriteLine(output);

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
