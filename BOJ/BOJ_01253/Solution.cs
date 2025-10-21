namespace Algorithm.BOJ.BOJ_01253
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01253/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Array.Sort(A);

            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                int l = 0, r = N - 1;

                while (l < r)
                {
                    int sum = A[l] + A[r];

                    if (l == i || sum < A[i])
                    {
                        l++;
                        continue;
                    }
                    if (r == i || sum > A[i])
                    {
                        r--;
                        continue;
                    }
                    cnt++;
                    break;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
