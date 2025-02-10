namespace Algorithm.BOJ.BOJ_17508
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_17508/input1.txt",
            "BOJ/BOJ_17508/input2.txt",
            "BOJ/BOJ_17508/input3.txt",
        ];

        private static int N;
        private static int M;
        private static char[,] matrix = {};

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            N = int.Parse(nm[0]);
            M = int.Parse(nm[1]);

            matrix = new char[N, M];
            for (int r = 0; r < N; r++)
            {
                string row = Console.ReadLine()!;
                for (int c = 0; c < M; c++) matrix[r, c] = row[c];
            }

            int cnt = 0;

            for (int r = 0; r < N / 2; r++)
            {
                for (int c = 0; c < M; c++)
                {
                    if (!CheckPair(r, c, ref cnt))
                    {
                        Console.WriteLine("-1");
                        return;
                    }
                }
            }

            if (N % 2 == 1)
            {
                for (int c = 0; c < (M + 1) / 2; c++)
                {
                    if (!CheckPair(N / 2, c, ref cnt))
                    {
                        Console.WriteLine("-1");
                        return;
                    }
                }
            }

            Console.WriteLine(cnt);
        }

        private static bool CheckPair(int r, int c, ref int cnt)
        {
            char card = matrix[r, c];
            char pair = matrix[N - 1 - r, M - 1 - c];

            if (r == N - 1 - r && c == M - 1 - c)
            {
                if (card != '8') return false;
            }

            if (card == '6')
            {
                if (pair == '6') cnt++;
                else if (pair != '9') return false;
            }
            else if (card == '7')
            {
                if (pair == '7') cnt++;
                else return false;
            }
            else if (card == '8')
            {
                if (pair != '8') return false;
            }
            else if (card == '9')
            {
                if (pair == '9') cnt++;
                else if (pair != '6') return false;
            }

            return true;
        }
    }
}
