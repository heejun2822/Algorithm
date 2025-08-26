namespace Algorithm.BOJ.BOJ_01680
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01680/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                string[] wn = Console.ReadLine()!.Split();
                int W = int.Parse(wn[0]);
                int N = int.Parse(wn[1]);

                int currentW = 0;
                int currentX = 0;
                int distance = 0;

                for (int i = 0; i < N; i++)
                {
                    string[] xw = Console.ReadLine()!.Split();
                    int x_i = int.Parse(xw[0]);
                    int w_i = int.Parse(xw[1]);

                    distance += x_i - currentX;

                    if (currentW + w_i < W)
                    {
                        currentW += w_i;
                        currentX = x_i;
                    }
                    else if (currentW + w_i == W)
                    {
                        currentW = 0;
                        currentX = 0;
                        distance += x_i;
                    }
                    else
                    {
                        currentW = w_i;
                        currentX = x_i;
                        distance += x_i * 2;
                    }
                }

                distance += currentX;

                Console.WriteLine(distance);
            }
        }
    }
}
