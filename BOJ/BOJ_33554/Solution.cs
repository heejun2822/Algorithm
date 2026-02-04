namespace Algorithm.BOJ.BOJ_33554
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_33554/input1.txt",
            "BOJ/BOJ_33554/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]), w = int.Parse(input[1]), h = int.Parse(input[2]);

            int[][] locks = new int[n][];

            for (int i = 0; i < n; i++)
            {
                locks[i] = new int[h];

                for (int r = 0; r < h; r++)
                {
                    locks[i][r] = w;

                    string row = Console.ReadLine()!;

                    for (int c = 0; c < w; c++)
                    {
                        if (row[c] == '#')
                        {
                            locks[i][r] = c;
                            break;
                        }
                    }
                }
            }

            int[] key = new int[h];

            for (int r = 0; r < h; r++)
            {
                key[r] = -1;

                string row = Console.ReadLine()!;

                for (int c = w - 1; c >= 0; c--)
                {
                    if (row[c] == '#')
                    {
                        key[r] = c;
                        break;
                    }
                }
            }

            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                bool fit = true;

                for (int r = 0; r < h; r++)
                {
                    if (locks[i][r] <= key[r])
                    {
                        fit = false;
                        break;
                    }
                }

                if (fit)
                    cnt++;
            }

            Console.WriteLine(cnt);
        }
    }
}
