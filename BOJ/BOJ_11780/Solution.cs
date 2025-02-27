namespace Algorithm.BOJ.BOJ_11780
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11780/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine()!);
            int m = int.Parse(sr.ReadLine()!);

            const int INF = 10_000_000;

            int[,] minCost = new int[n + 1, n + 1];
            int[,] trace = new int[n + 1, n + 1];

            for (int i = 1; i <= n; i++)
                for (int j = 1; j <= n; j++)
                    minCost[i, j] = i == j ? 0 : INF;

            for (int _ = 0; _ < m; _++)
            {
                string[] info = sr.ReadLine()!.Split();
                int a = int.Parse(info[0]);
                int b = int.Parse(info[1]);
                int c = int.Parse(info[2]);
                minCost[a, b] = Math.Min(minCost[a, b], c);
                trace[a, b] = a;
            }

            for (int k = 1; k <= n; k++)
                for (int i = 1; i <= n; i++)
                    for (int j = 1; j <= n; j++)
                        if (minCost[i, k] + minCost[k, j] < minCost[i, j])
                        {
                            minCost[i, j] = minCost[i, k] + minCost[k, j];
                            trace[i, j] = trace[k, j];
                        }

            StringBuilder answer = new();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (minCost[i, j] == INF) minCost[i, j] = 0;
                    answer.Append(minCost[i, j]).Append(' ');
                }
                answer.Append('\n');
            }

            Stack<int> stack = new();

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (minCost[i, j] == 0)
                    {
                        answer.AppendLine("0");
                        continue;
                    }

                    int city = j;
                    while (city != 0)
                    {
                        stack.Push(city);
                        city = trace[i, city];
                    }

                    answer.Append(stack.Count).Append(' ');
                    while (stack.Count > 0) answer.Append(stack.Pop()).Append(' ');
                    answer.Append('\n');
                }
            }

            sw.WriteLine(answer);

            sr.Close();
            sw.Close();
        }
    }
}
