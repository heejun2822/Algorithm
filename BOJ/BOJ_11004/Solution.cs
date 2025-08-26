namespace Algorithm.BOJ.BOJ_11004
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11004/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), K = ReadInt(sr);

            PriorityQueue<int, int> priorityQueue = new(K);

            for (int i = 1; i <= N; i++)
            {
                int A = ReadInt(sr);

                if (i <= K)
                {
                    priorityQueue.Enqueue(A, -A);
                }
                else if (A < priorityQueue.Peek())
                {
                    priorityQueue.Dequeue();
                    priorityQueue.Enqueue(A, -A);
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
