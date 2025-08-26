namespace Algorithm.BOJ.BOJ_13305
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13305/input1.txt",
            "BOJ/BOJ_13305/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] roads = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int[] prices = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            long expense = 0;
            long minPrice = (long)1e9;
            for (int i = 0; i < N - 1; i++)
            {
                minPrice = Math.Min(minPrice, prices[i]);
                expense += minPrice * roads[i];
            }

            Console.WriteLine(expense);
        }
    }
}
