namespace Algorithm.BOJ.BOJ_14719
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14719/input1.txt",
            "BOJ/BOJ_14719/input2.txt",
            "BOJ/BOJ_14719/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int H = ReadInt(sr), W = ReadInt(sr);

            Stack<(int idx, int h)> blockStack = new();
            int amount = 0;

            for (int i = 0; i < W; i++)
            {
                int h = ReadInt(sr);

                while (blockStack.Count > 0 && blockStack.Peek().h <= h)
                {
                    int wateredH = blockStack.Pop().h;
                    if (blockStack.TryPeek(out (int idx, int h) block))
                        amount += (i - block.idx - 1) * (Math.Min(h, block.h) - wateredH);
                }
                blockStack.Push((i, h));
            }

            sw.WriteLine(amount);

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
