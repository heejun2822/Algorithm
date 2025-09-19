namespace Algorithm.BOJ.BOJ_22251
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_22251/input1.txt",
            "BOJ/BOJ_22251/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int[,] digits =
            {
                { 1, 1, 1, 0, 1, 1, 1 },
                { 0, 0, 1, 0, 0, 1, 0 },
                { 1, 0, 1, 1, 1, 0, 1 },
                { 1, 0, 1, 1, 0, 1, 1 },
                { 0, 1, 1, 1, 0, 1, 0 },
                { 1, 1, 0, 1, 0, 1, 1 },
                { 1, 1, 0, 1, 1, 1, 1 },
                { 1, 0, 1, 0, 0, 1, 0 },
                { 1, 1, 1, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 0, 1, 1 },
            };

            int[,] twistCost = new int[10, 10];

            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    int cost = 0;
                    for (int l = 0; l < 7; l++)
                        if (digits[i, l] != digits[j, l])
                            cost++;
                    twistCost[i, j] = twistCost[j, i] = cost;
                }
            }

            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            int P = int.Parse(input[2]);
            int X = int.Parse(input[3]);

            int[] digitX = new int[K];
            for (int i = 0; i < K; i++)
            {
                digitX[i] = X % 10;
                X /= 10;
            }

            int cnt = -1;

            for (int f = 1; f <= N; f++)
            {
                int cost = 0;
                int num = f;

                for (int i = 0; i < K; i++)
                {
                    if ((cost += twistCost[digitX[i], num % 10]) > P) break;
                    num /= 10;
                }

                if (cost <= P)
                    cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}
