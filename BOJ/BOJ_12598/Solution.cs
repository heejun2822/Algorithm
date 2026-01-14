namespace Algorithm.BOJ.BOJ_12598
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12598/input.txt",
        ];

        public static void Run(string[] args)
        {
            int C = ReadInt();

            for (int X = 1; X <= C; X++)
            {
                int N = ReadInt(), T = ReadInt();
                int E = ReadInt();

                int[] employees = new int[N + 1];
                List<int>[] carPassengers = new List<int>[N + 1];

                for (int i = 1; i <= N; i++)
                    carPassengers[i] = new();

                for (int _ = 0; _ < E; _++)
                {
                    int H = ReadInt(), P = ReadInt();
                    employees[H]++;
                    if (P > 0)
                        carPassengers[H].Add(P);
                }

                bool isPossible = true;
                System.Text.StringBuilder cars = new();

                for (int h = 1; h <= N; h++)
                {
                    if (h == T || employees[h] == 0)
                    {
                        cars.Append('0').Append(' ');
                        continue;
                    }

                    carPassengers[h].Sort((a, b) => b - a);

                    int totalPassengers = 0;

                    for (int i = 0; i < carPassengers[h].Count; i++)
                    {
                        if ((totalPassengers += carPassengers[h][i]) >= employees[h])
                        {
                            cars.Append(i + 1).Append(' ');
                            break;
                        }
                    }

                    if (totalPassengers < employees[h])
                    {
                        isPossible = false;
                        break;
                    }
                }

                if (isPossible)
                    Console.WriteLine($"Case #{X}: {cars}");
                else
                    Console.WriteLine($"Case #{X}: IMPOSSIBLE");
            }
        }

        private static int ReadInt()
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = Console.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { Console.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
