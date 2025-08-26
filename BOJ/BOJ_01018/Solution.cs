namespace Algorithm.BOJ.BOJ_01018
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01018/input1.txt",
            "BOJ/BOJ_01018/input2.txt",
            "BOJ/BOJ_01018/input3.txt",
            "BOJ/BOJ_01018/input4.txt",
            "BOJ/BOJ_01018/input5.txt",
            "BOJ/BOJ_01018/input6.txt",
            "BOJ/BOJ_01018/input7.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            bool[,] board = new bool[N, M];
            for (int i = 0; i < N; i++)
            {
                string row = Console.ReadLine()!;
                for (int j = 0; j < M; j++) board[i, j] = row[j] == 'W';
            }
            int min = 64;
            for (int a = 0; a <= N - 8; a++)
            {
                for (int b = 0; b <= M - 8; b++)
                {
                    int cnt = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        for (int j = 0; j < 8; j++)
                        {
                            if (board[a + i, b + j] == ((i + j) % 2 == 0)) cnt++;
                        }
                    }
                    min = Math.Min(min, Math.Min(cnt, 64 - cnt));
                }
            }
            Console.WriteLine(min);
        }
    }
}
