namespace Algorithm.BOJ.BOJ_27573
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_27573/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]);
            int l = int.Parse(input[1]);
            int h = int.Parse(input[2]);

            int[] accSum = new int[n + 1];

            for (int i = 1; i <= n; i++)
                accSum[i] = accSum[i - 1] + int.Parse(Console.ReadLine()!);

            int min = n;
            int max = 0;

            for (int size = l; size <= h; size++)
            {
                for (int offset = 1; offset <= size; offset++)
                {
                    int cnt = 0;
                    int idx = offset;

                    while (idx - size < n)
                    {
                        if (accSum[Math.Min(idx, n)] - accSum[Math.Max(idx - size, 0)] > 0)
                            cnt++;
                        idx += size;
                    }

                    min = Math.Min(min, cnt);
                    max = Math.Max(max, cnt);
                }
            }

            Console.WriteLine($"{min} {max}");
        }
    }
}
