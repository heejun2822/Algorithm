namespace Algorithm.BOJ.BOJ_10986
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10986/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int[] counts = new int[M];
            int acc = 0;
            counts[acc]++;
            for (int i = 0; i < N; i++)
            {
                acc = (acc + A[i]) % M;
                counts[acc]++;
            }

            long cnt = 0;
            for (int i = 0; i < M; i++)
            {
                if (counts[i] < 2) continue;
                cnt += (long)counts[i] * (counts[i] - 1) / 2;
            }

            Console.WriteLine(cnt);
        }
    }
}
