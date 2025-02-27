namespace Algorithm.BOJ.BOJ_11779
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11779/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine()!);
            int m = int.Parse(sr.ReadLine()!);

            List<(int destCity, int cost)>[] buses = new List<(int, int)>[n + 1];
            for (int i = 1; i <= n; i++) buses[i] = new();
            for (int _ = 0; _ < m; _++)
            {
                string[] info = sr.ReadLine()!.Split();
                int from = int.Parse(info[0]);
                int to = int.Parse(info[1]);
                int cost = int.Parse(info[2]);
                buses[from].Add((to, cost));
            }

            string[] ab = sr.ReadLine()!.Split();
            int A = int.Parse(ab[0]);
            int B = int.Parse(ab[1]);

            int[] minCost = new int[n + 1];
            Array.Fill(minCost, 100_000_000);

            int[] trace = new int[n + 1];

            PriorityQueue<int, int> connected = new();
            connected.Enqueue(A, minCost[A] = 0);

            while (connected.Count > 0)
            {
                int leastCostCity = connected.Dequeue();

                if (leastCostCity == B) break;

                foreach ((int destCity, int cost) in buses[leastCostCity])
                {
                    int newCost = minCost[leastCostCity] + cost;
                    if (newCost < minCost[destCity])
                    {
                        connected.Enqueue(destCity, minCost[destCity] = newCost);
                        trace[destCity] = leastCostCity;
                    }
                }
            }

            Stack<int> stack = new();
            int city = B;
            while (city != 0)
            {
                stack.Push(city);
                city = trace[city];
            }

            int cityCnt = stack.Count;
            StringBuilder path = new();
            while (stack.Count > 0) path.Append(stack.Pop()).Append(' ');

            sw.WriteLine(minCost[B]);
            sw.WriteLine(cityCnt);
            sw.WriteLine(path);

            sr.Close();
            sw.Close();
        }
    }
}
