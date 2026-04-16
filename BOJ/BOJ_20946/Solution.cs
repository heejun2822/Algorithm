namespace Algorithm.BOJ.BOJ_20946
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20946/input1.txt",
            "BOJ/BOJ_20946/input2.txt",
        ];

        public static void Run(string[] args)
        {
            long N = long.Parse(Console.ReadLine()!);

            List<long> A = new();
            int cnt = 0;

            for (long i = 2; i * i <= N; i++)
            {
                while (N % i == 0)
                {
                    if (cnt % 2 == 1)
                        A[^1] *= i;
                    else
                        A.Add(i);
                    cnt++;
                    N /= i;
                }
                if (N == 1) break;
            }
            if (N != 1)
            {
                if (cnt % 2 == 1)
                    A[^1] *= N;
                else
                    A.Add(N);
                cnt++;
            }

            if (cnt == 1)
            {
                Console.WriteLine(-1);
                return;
            }
            if (cnt % 2 == 1)
            {
                A[^2] *= A[^1];
                A.RemoveAt(A.Count - 1);
            }
            Console.WriteLine(string.Join(' ', A));
        }
    }
}
