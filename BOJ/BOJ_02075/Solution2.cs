namespace Algorithm.BOJ.BOJ_02075
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02075/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            PriorityQueue<int, int> priorityQueue = new(N);

            for (int _ = 0; _ < N; _++)
            {
                int num = ReadInt(sr);
                priorityQueue.Enqueue(num, num);
            }

            int cnt = N * (N - 1);
            for (int _ = 0; _ < cnt; _++)
            {
                int num = ReadInt(sr);
                if (num > priorityQueue.Peek())
                {
                    priorityQueue.Dequeue();
                    priorityQueue.Enqueue(num, num);
                }
            }

            sw.WriteLine(priorityQueue.Peek());

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
