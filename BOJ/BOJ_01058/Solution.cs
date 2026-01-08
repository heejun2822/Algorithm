namespace Algorithm.BOJ.BOJ_01058
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01058/input1.txt",
            "BOJ/BOJ_01058/input2.txt",
            "BOJ/BOJ_01058/input3.txt",
            "BOJ/BOJ_01058/input4.txt",
            "BOJ/BOJ_01058/input5.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int[,] friendDepth = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string row = Console.ReadLine()!;
                for (int j = 0; j < N; j++)
                    friendDepth[i, j] = i == j ? 0 : row[j] == 'Y' ? 1 : 2500;
            }

            for (int k = 0; k < N; k++)
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < N; j++)
                        friendDepth[i, j] = Math.Min(friendDepth[i, j], friendDepth[i, k] + friendDepth[k, j]);

            int maxCnt = 0;

            for (int i = 0; i < N; i++)
            {
                int cnt = 0;
                for (int j = 0; j < N; j++)
                    if (friendDepth[i, j] == 1 || friendDepth[i, j] == 2)
                        cnt++;
                maxCnt = Math.Max(maxCnt, cnt);
            }

            Console.WriteLine(maxCnt);
        }
    }
}
