namespace Algorithm.BOJ.BOJ_02606
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02606/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int computerCnt = int.Parse(sr.ReadLine()!);
            int connectionCnt = int.Parse(sr.ReadLine()!);
            bool[,] connected = new bool[computerCnt + 1, computerCnt + 1];
            for (int _ = 0; _ < connectionCnt; _++)
            {
                string[] com = sr.ReadLine()!.Split();
                int com1 = int.Parse(com[0]), com2 = int.Parse(com[1]);
                connected[com1, com2] = connected[com2, com1] = true;
            }

            bool[] visited = new bool[computerCnt + 1];
            Stack<int> stack = new();
            int cnt = 0;

            visited[1] = true;
            stack.Push(1);

            while (stack.Count > 0)
            {
                int c = stack.Pop();
                for (int i = 1; i <= computerCnt; i++)
                {
                    if (connected[c, i] && !visited[i])
                    {
                        visited[i] = true;
                        stack.Push(i);
                        cnt++;
                    }
                }
            }

            sw.WriteLine(cnt);

            sr.Close();
            sw.Close();
        }
    }
}
