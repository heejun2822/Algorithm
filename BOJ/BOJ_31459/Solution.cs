namespace Algorithm.BOJ.BOJ_31459
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31459/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = ReadInt();

            System.Text.StringBuilder output = new();

            while (T-- > 0)
            {
                int X = ReadInt(), Y = ReadInt(), x = ReadInt(), y = ReadInt();

                bool[,] isBlocked = new bool[Y, X];
                int cnt = 0;

                for (int r = 0; r < Y; r++)
                {
                    for (int c = 0; c < X; c++)
                    {
                        if (isBlocked[r, c]) continue;

                        cnt++;
                        if (r + y < Y && c + x < X)
                            isBlocked[r + y, c + x] = true;
                    }
                }

                output.AppendLine(cnt.ToString());
            }

            Console.Write(output);
        }

        private static int ReadInt()
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = Console.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { Console.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
