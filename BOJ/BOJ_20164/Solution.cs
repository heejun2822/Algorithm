namespace Algorithm.BOJ.BOJ_20164
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20164/input1.txt",
            "BOJ/BOJ_20164/input2.txt",
            "BOJ/BOJ_20164/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            (int min, int max) = OddHolicOperation(N);

            Console.WriteLine(min + " " + max);

            (int min, int max) OddHolicOperation(int N)
            {
                int min = int.MaxValue, max = 0;

                if (N < 10)
                {
                    min = max = 0;
                }
                else if (N < 100)
                {
                    (min, max) = OddHolicOperation(N % 10 + N / 10);
                }
                else
                {
                    for (int i = 10; i <= N; i *= 10)
                    {
                        int div1 = N % i;
                        int tmp = N / i;

                        for (int j = 10; j <= tmp; j *= 10)
                        {
                            int div2 = tmp % j;
                            int div3 = tmp / j;

                            var res = OddHolicOperation(div1 + div2 + div3);
                            min = Math.Min(min, res.min);
                            max = Math.Max(max, res.max);
                        }
                    }
                }

                int cnt = CountOdd(N);
                min += cnt;
                max += cnt;

                return (min, max);
            }

            int CountOdd(int N)
            {
                int cnt = 0;

                while (N > 0)
                {
                    if (N % 2 == 1)
                        cnt++;
                    N /= 10;
                }

                return cnt;
            }
        }
    }
}
