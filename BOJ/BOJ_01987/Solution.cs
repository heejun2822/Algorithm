namespace Algorithm.BOJ.BOJ_01987
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01987/input1.txt",
            "BOJ/BOJ_01987/input2.txt",
            "BOJ/BOJ_01987/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int R = int.Parse(input[0]);
            int C = int.Parse(input[1]);

            int[,] board = new int[R, C];

            for (int i = 0; i < R; i++)
            {
                string row = Console.ReadLine()!;
                for (int j = 0; j < C; j++)
                    board[i, j] = row[j] - 'A';
            }

            bool[] visited = new bool[26];
            int maxCnt = 0;

            DFS(0, 0, 1);

            Console.WriteLine(maxCnt);

            void DFS(int r, int c, int cnt)
            {
                if (visited[board[r, c]] || maxCnt == 26) return;

                visited[board[r, c]] = true;
                maxCnt = Math.Max(maxCnt, cnt);

                if (r - 1 >= 0) DFS(r - 1, c, cnt + 1);
                if (r + 1 < R) DFS(r + 1, c, cnt + 1);
                if (c - 1 >= 0) DFS(r, c - 1, cnt + 1);
                if (c + 1 < C) DFS(r, c + 1, cnt + 1);

                visited[board[r, c]] = false;
            }
        }
    }
}
