namespace Algorithm.BOJ.BOJ_02310
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02310/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n;
            bool[] isTroll;
            int[] amount;
            List<int>[] doorLists;
            bool[] visited;

            while ((n = ReadInt(sr)) != 0)
            {
                isTroll = new bool[n + 1];
                amount = new int[n + 1];
                doorLists = new List<int>[n + 1];
                visited = new bool[n + 1];

                for (int i = 1; i <= n; i++)
                {
                    isTroll[i] = sr.Read() == 'T';
                    amount[i] = ReadInt(sr);
                    doorLists[i] = new();
                    int door;
                    while ((door = ReadInt(sr)) != 0)
                        doorLists[i].Add(door);
                }

                sw.WriteLine(DFS(1, 0) ? "Yes" : "No");
            }

            sr.Close();
            sw.Close();

            bool DFS(int room, int cash)
            {
                if (isTroll[room])
                    cash -= amount[room];
                else
                    cash = Math.Max(cash, amount[room]);

                if (cash < 0)
                    return false;

                if (room == n)
                    return true;

                visited[room] = true;

                foreach (int nextRoom in doorLists[room])
                    if (!visited[nextRoom] && DFS(nextRoom, cash))
                        return true;

                visited[room] = false;

                return false;
            }
        }

        private static int ReadInt(StreamReader sr)
        {
            bool isValid = false;
            int c, value = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) { if (isValid) break; else continue; }
                if (c == '\r') { sr.Read(); if (isValid) break; else continue; }
                if (c == '-') { sign = -1; continue; }
                value = value * 10 + c - '0';
                isValid = true;
            }
            return value * sign;
        }
    }
}
