namespace Algorithm.BOJ.BOJ_16293
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16293/input1.txt",
            "BOJ/BOJ_16293/input2.txt",
            "BOJ/BOJ_16293/input3.txt",
            "BOJ/BOJ_16293/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int h = int.Parse(input[0]);
            int w = int.Parse(input[1]);

            float cg = 0;
            int cnt = 0;
            int gl = 0, gr = 0;

            for (int y = h - 1; y >= 0; y--)
            {
                string floor = Console.ReadLine()!;

                for (int x = 0; x < w; x++)
                    if (floor[x] != '.')
                    {
                        cg += x + 0.5f;
                        cnt++;
                    }

                if (y == 0)
                {
                    for (int x = 0; x < w; x++)
                        if (floor[x] != '.')
                        {
                            gl = x;
                            break;
                        }
                    for (int x = w - 1; x >= 0; x--)
                        if (floor[x] != '.')
                        {
                            gr = x + 1;
                            break;
                        }
                }
            }

            cg /= cnt;

            Console.WriteLine(cg < gl ? "left" : cg > gr ? "right" : "balanced");
        }
    }
}
