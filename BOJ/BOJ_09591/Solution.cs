namespace Algorithm.BOJ.BOJ_09591
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09591/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]), M = int.Parse(input[1]);

            (int f, int x, int y)[] places = new (int, int, int)[N];

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine()!.Split();
                int f = int.Parse(input[0]);
                int x = int.Parse(input[1]);
                int y = int.Parse(input[2]);
                places[i] = (f, x, y);
            }

            List<(int destination, double cost)>[] pathLists = new List<(int, double)>[N];
            for (int i = 0; i < N; i++)
                pathLists[i] = new();

            for (int _ = 0; _ < M; _++)
            {
                input = Console.ReadLine()!.Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                string type = input[2];

                if (type[0] == 'w' || type[0] == 's')
                {
                    double cost = GetDistance(a, b);
                    pathLists[a].Add((b, cost));
                    pathLists[b].Add((a, cost));
                }
                else if (type[0] == 'l')
                {
                    pathLists[a].Add((b, 1));
                    pathLists[b].Add((a, 1));
                }
                else if (type[0] == 'e')
                {
                    double cost = GetDistance(a, b) * 3;
                    pathLists[a].Add((b, 1));
                    pathLists[b].Add((a, cost));
                }
            }

            int Q = int.Parse(Console.ReadLine()!);

            PriorityQueue<int, double> prQueue = new();
            double[] minCost = new double[N];
            bool[] visited = new bool[N];
            int[] trace = new int[N];
            Stack<int> stack = new();
            System.Text.StringBuilder output = new();

            while (Q-- > 0)
            {
                input = Console.ReadLine()!.Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);

                prQueue.Clear();
                Array.Fill(minCost, double.MaxValue);
                Array.Fill(visited, false);

                prQueue.Enqueue(a, minCost[a] = 0);
                trace[a] = -1;

                while (prQueue.Count > 0)
                {
                    int place = prQueue.Dequeue();

                    if (place == b) break;
                    if (visited[place]) continue;

                    visited[place] = true;

                    foreach ((int destination, double cost) in pathLists[place])
                    {
                        if (visited[destination]) continue;

                        double newCost = minCost[place] + cost;
                        if (newCost < minCost[destination])
                        {
                            prQueue.Enqueue(destination, minCost[destination] = newCost);
                            trace[destination] = place;
                        }
                    }
                }

                int p = b;
                while (p != -1)
                {
                    stack.Push(p);
                    p = trace[p];
                }

                while (stack.Count > 0)
                    output.Append(stack.Pop()).Append(' ');
                output.AppendLine();
            }

            Console.Write(output);

            double GetDistance(int a, int b)
            {
                int df = (places[b].f - places[a].f) * 5;
                int dx = places[b].x - places[a].x;
                int dy = places[b].y - places[a].y;
                return Math.Sqrt(df * df + dx * dx + dy * dy);
            }
        }
    }
}
