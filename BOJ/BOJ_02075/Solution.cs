namespace Algorithm.BOJ.BOJ_02075
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
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

            Stack<int>[] stacks = new Stack<int>[N];
            for (int i = 0; i < N; i++) stacks[i] = new(N - 1);

            for (int _ = 0; _ < N - 1; _++)
                for (int i = 0; i < N; i++)
                    stacks[i].Push(ReadInt(sr));

            PriorityQueue<(int val, int idx), int> priorityQueue = new(N);

            for (int i = 0; i < N; i++)
            {
                int num = ReadInt(sr);
                priorityQueue.Enqueue((num, i), -num);
            }

            for (int _ = 0; _ < N - 1; _++)
            {
                int idx = priorityQueue.Dequeue().idx;
                int num = stacks[idx].Pop();
                priorityQueue.Enqueue((num, idx), -num);
            }

            sw.WriteLine(priorityQueue.Dequeue().val);

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
