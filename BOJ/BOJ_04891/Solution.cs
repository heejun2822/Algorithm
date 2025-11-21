namespace Algorithm.BOJ.BOJ_04891
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04891/input.txt",
        ];

        public static void Run(string[] args)
        {
            int k = 1;

            while (true)
            {
                string[] input = Console.ReadLine()!.Split();
                int A = int.Parse(input[0]);
                int B = int.Parse(input[1]);

                if (A == 0 && B == 0) break;

                int X = 0;
                int D = 0;

                int lim = (int)Math.Sqrt(Math.Max(A, B));

                for (int p = 2; p <= lim; p++)
                {
                    int cntA = 0, cntB = 0;

                    while (A % p == 0)
                    {
                        A /= p;
                        cntA++;
                    }
                    while (B % p == 0)
                    {
                        B /= p;
                        cntB++;
                    }

                    if (cntA > 0 || cntB > 0)
                    {
                        X++;
                        D += Math.Abs(cntA - cntB);
                    }
                }

                if (A != 1)
                {
                    X++;
                    D++;
                }
                if (B != 1)
                {
                    if (A != B)
                    {
                        X++;
                        D++;
                    }
                    else
                    {
                        D--;
                    }
                }

                Console.WriteLine($"{k++}. {X}:{D}");
            }
        }
    }
}
