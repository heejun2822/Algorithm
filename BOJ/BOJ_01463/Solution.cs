namespace Algorithm.BOJ.BOJ_01463
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01463/input1.txt",
            "BOJ/BOJ_01463/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            HashSet<int> visited = new() { N };
            Queue<(int num, int cnt)> queue = new();
            queue.Enqueue((N, 0));

            int ans = 0;
            while (queue.Count > 0)
            {
                (int num, int cnt) = queue.Dequeue();
                if (num % 3 == 0)
                {
                    int next = num / 3;
                    if (next == 1) { ans = cnt + 1; break; }
                    if (!visited.Contains(next)) queue.Enqueue((next, cnt + 1));
                    visited.Add(next);
                }
                if (num % 2 == 0)
                {
                    int next = num / 2;
                    if (next == 1) { ans = cnt + 1; break; }
                    if (!visited.Contains(next)) queue.Enqueue((next, cnt + 1));
                    visited.Add(next);
                }
                if (num > 1)
                {
                    int next = num - 1;
                    if (next == 1) { ans = cnt + 1; break; }
                    if (!visited.Contains(next)) queue.Enqueue((next, cnt + 1));
                    visited.Add(next);
                }
                else break;
            }

            Console.WriteLine(ans);
        }
    }
}
