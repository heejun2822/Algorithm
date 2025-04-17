namespace Algorithm.BOJ.BOJ_02696
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02696/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = ReadInt(sr);

            for (int _ = 0; _ < T; _++)
            {
                int M = ReadInt(sr);

                int half = M / 2;
                PriorityQueue<int, int> leftQueue = new(half + 1);
                PriorityQueue<int, int> rightQueue = new(half);
                System.Text.StringBuilder answer = new($"{half + 1}\n");

                int num = ReadInt(sr);
                leftQueue.Enqueue(num, -num);
                answer.Append(leftQueue.Peek()).Append(' ');

                for (int i = 1; i <= half; i++)
                {
                    num = ReadInt(sr);

                    if (num < leftQueue.Peek())
                        num = leftQueue.EnqueueDequeue(num, -num);
                    rightQueue.Enqueue(num, num);

                    num = ReadInt(sr);

                    if (num > rightQueue.Peek())
                        num = rightQueue.EnqueueDequeue(num, num);
                    leftQueue.Enqueue(num, -num);

                    if (i % 10 == 0)
                        answer.AppendLine();
                    answer.Append(leftQueue.Peek()).Append(' ');
                }

                sw.WriteLine(answer);
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
