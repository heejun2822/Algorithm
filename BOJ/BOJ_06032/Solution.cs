namespace Algorithm.BOJ.BOJ_06032
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06032/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            PriorityQueue<(int idx, int price), double> priorityQueue = new();

            for (int i = 1; i <= N; i++)
            {
                int J = ReadInt(sr), P = ReadInt(sr);
                double HFM = (double)J / P;

                if (priorityQueue.Count < 3)
                {
                    priorityQueue.Enqueue((i, P), HFM);
                }
                else if (priorityQueue.TryPeek(out (int, int) ele, out double prt) && prt < HFM)
                {
                    priorityQueue.Dequeue();
                    priorityQueue.Enqueue((i, P), HFM);
                }
            }

            int totalPrice = 0;
            int[] orders = new int[3];

            for (int i = 2; i >= 0; i--)
            {
                (int idx, int price) = priorityQueue.Dequeue();
                totalPrice += price;
                orders[i] = idx;
            }

            sw.WriteLine(totalPrice);
            foreach (int idx in orders)
                sw.WriteLine(idx);

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
