namespace Algorithm.BOJ.BOJ_13913
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_13913/input1.txt",
            "BOJ/BOJ_13913/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nk = sr.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);

            int[] trace = new int[100_001];
            Array.Fill(trace, -1);
            trace[N] = -2;

            Queue<int> queue = new();
            queue.Enqueue(N);

            int queueCount;
            bool found = false;
            int time = 0;

            while ((queueCount = queue.Count) > 0 && !found)
            {
                for (int _ = 0; _ < queueCount; _++)
                {
                    int x = queue.Dequeue();

                    if (x == K)
                    {
                        found = true;
                        break;
                    }

                    int[] nxs = { x - 1, x + 1, x * 2 };

                    foreach (int nx in nxs)
                    {
                        if (nx < 0 || nx > 100_000) continue;

                        if (trace[nx] == -1)
                        {
                            trace[nx] = x;
                            queue.Enqueue(nx);
                        }
                    }
                }

                if (!found) time++;
            }

            Stack<int> stack = new();
            int X = K;
            while (X != -2)
            {
                stack.Push(X);
                X = trace[X];
            }

            StringBuilder path = new();
            while (stack.Count > 0)
            {
                path.Append(stack.Pop());
                path.Append(' ');
            }

            sw.WriteLine(time);
            sw.WriteLine(path);

            sr.Close();
            sw.Close();
        }
    }
}
