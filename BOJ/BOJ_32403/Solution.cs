namespace Algorithm.BOJ.BOJ_32403
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_32403/input1.txt",
            "BOJ/BOJ_32403/input2.txt",
            "BOJ/BOJ_32403/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int T = int.Parse(input[1]);
            int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            List<int> divisors = new();

            for (int i = 1; i <= T; i++)
                if (T % i == 0)
                    divisors.Add(i);

            divisors.Add(int.MaxValue);

            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                int l = 0, r = divisors.Count - 1;

                while (l < r)
                {
                    int m = (l + r + 1) / 2;
                    if (a[i] >= divisors[m])
                        l = m;
                    else
                        r = m - 1;
                }

                cnt += Math.Min(a[i] - divisors[l], divisors[l + 1] - a[i]);
            }

            Console.WriteLine(cnt);
        }
    }
}
