namespace Algorithm.BOJ.BOJ_21773
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_21773/input1.txt",
            "BOJ/BOJ_21773/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = ReadInt(sr);
            int n = ReadInt(sr);

            PriorityQueue<(int, int, int), (int, int)> priorityQueue = new(n);

            for (int _ = 0; _ < n; _++)
            {
                int A = ReadInt(sr), B = ReadInt(sr), C = ReadInt(sr);
                priorityQueue.Enqueue((A, B, C), (-C, A));
            }

            for (int _ = 0; _ < T; _++)
            {
                (int A, int B, int C) = priorityQueue.Dequeue();
                sw.WriteLine(A);
                B--;
                C--;
                if (B > 0)
                    priorityQueue.Enqueue((A, B, C), (-C, A));
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
