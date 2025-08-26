namespace Algorithm.BOJ.BOJ_01912
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01912/input1.txt",
            "BOJ/BOJ_01912/input2.txt",
            "BOJ/BOJ_01912/input3.txt",
        ];

        // 시간 초과
        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] sqn = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int[] acc = new int[n];
            acc[0] = sqn[0];
            for (int i = 1; i < n; i++) acc[i] = acc[i - 1] + sqn[i];
            int max = acc.Max();

            int idx = 0, sum = 0;
            while (idx < n - 1)
            {
                if ((sum += sqn[idx++]) > 0) continue;
                for (int i = idx; i < n; i++) max = Math.Max(max, acc[i] -= sum);
                sum = 0;
            }

            Console.WriteLine(max);
        }
    }
}
