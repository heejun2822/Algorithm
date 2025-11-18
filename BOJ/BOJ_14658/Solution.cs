namespace Algorithm.BOJ.BOJ_14658
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14658/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int L = int.Parse(input[2]);
            int K = int.Parse(input[3]);

            (int x, int y)[] stars = new (int, int)[K];

            for (int i = 0; i < K; i++)
            {
                input = Console.ReadLine()!.Split();
                stars[i] = (int.Parse(input[0]), int.Parse(input[1]));
            }

            int minCnt = K;

            for (int i = 0; i < K; i++)
            {
                int X = stars[i].x;

                for (int j = 0; j < K; j++)
                {
                    int Y = stars[j].y;

                    int cnt = K;

                    foreach ((int x, int y) in stars)
                        if (x >= X && x <= X + L && y >= Y && y <= Y + L)
                            cnt--;

                    minCnt = Math.Min(minCnt, cnt);
                }
            }

            Console.WriteLine(minCnt);
        }
    }
}
