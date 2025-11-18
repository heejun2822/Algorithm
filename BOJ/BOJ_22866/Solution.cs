namespace Algorithm.BOJ.BOJ_22866
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_22866/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int[] heights = new int[N + 1];

            (int cnt, int idx)[] visibles = new (int, int)[N + 1];
            Stack<int> stack = new();

            for (int i = 1; i <= N; i++)
            {
                heights[i] = ReadInt(sr);

                while (stack.TryPeek(out int idx) && heights[idx] <= heights[i])
                    stack.Pop();

                if (stack.Count > 0)
                    visibles[i] = (stack.Count, stack.Peek());

                stack.Push(i);
            }

            stack.Clear();

            for (int i = N; i >= 1; i--)
            {
                while (stack.TryPeek(out int idx) && heights[idx] <= heights[i])
                    stack.Pop();

                if (stack.Count > 0)
                {
                    visibles[i].cnt += stack.Count;
                    if (visibles[i].idx == 0 || stack.Peek() - i < i - visibles[i].idx)
                        visibles[i].idx = stack.Peek();
                }

                stack.Push(i);
            }

            System.Text.StringBuilder output = new();

            for (int i = 1; i <= N; i++)
                output.AppendLine(visibles[i].cnt == 0 ? "0" : $"{visibles[i].cnt} {visibles[i].idx}");

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
