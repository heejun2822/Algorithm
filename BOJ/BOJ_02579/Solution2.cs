namespace Algorithm.BOJ.BOJ_02579
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02579/input.txt",
        ];

        public static void Run(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine()!);
            int[] stairs = new int[cnt];
            for (int i = 0; i < cnt; i++) stairs[i] = int.Parse(Console.ReadLine()!);

            int[] acc = new int[cnt];
            for (int i = 0; i < cnt; i++)
                acc[i] = Math.Max(
                    i >= 2 ? acc[i - 2] : 0,
                    (i >= 3 ? acc[i - 3] : 0) + (i >= 1 ? stairs[i - 1] : 0)
                ) + stairs[i];

            Console.WriteLine(acc[cnt - 1]);
        }
    }
}
