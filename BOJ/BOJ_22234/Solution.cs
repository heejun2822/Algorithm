namespace Algorithm.BOJ.BOJ_22234
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_22234/input1.txt",
            "BOJ/BOJ_22234/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), T = ReadInt(sr), W = ReadInt(sr);
            Queue<(int P, int t)> queue = new(N);

            for (int _ = 0; _ < N; _++)
            {
                int P = ReadInt(sr), t = ReadInt(sr);
                queue.Enqueue((P, t));
            }

            int M = ReadInt(sr);
            PriorityQueue<(int P, int t), int> priorityQueue = new(M);

            for (int _ = 0; _ < M; _++)
            {
                int P = ReadInt(sr), t = ReadInt(sr), c = ReadInt(sr);
                priorityQueue.Enqueue((P, t), c);
            }

            int time = 0;
            System.Text.StringBuilder output = new();

            while (time < W)
            {
                (int P, int t) = queue.Dequeue();

                int processTime = Math.Min(t, T);
                int cnt = Math.Min(processTime, W - time);

                for (int _ = 0; _ < cnt; _++)
                    output.AppendLine(P.ToString());

                t -= processTime;
                time += processTime;

                while (priorityQueue.TryPeek(out var ele, out int c) && c <= time)
                    queue.Enqueue(priorityQueue.Dequeue());

                if (t > 0)
                    queue.Enqueue((P, t));
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
