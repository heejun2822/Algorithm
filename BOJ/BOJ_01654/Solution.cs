namespace Algorithm.BOJ.BOJ_01654
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01654/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] kn = Console.ReadLine()!.Split();
            int K = int.Parse(kn[0]);
            int N = int.Parse(kn[1]);
            int[] cableLengths = new int[K];
            int low = 1, high = 1;
            for (int i = 0; i < K; i++)
            {
                cableLengths[i] = int.Parse(Console.ReadLine()!);
                high = Math.Max(high, cableLengths[i]);
            }

            while (low < high)
            {
                int mid = (int)((1L + low + high) / 2);
                int cnt = 0;
                foreach (int len in cableLengths)
                {
                    cnt += len / mid;
                    if (cnt >= N) break;
                }
                if (cnt >= N) low = mid;
                else high = mid - 1;
            }

            Console.WriteLine(high);
        }
    }
}
