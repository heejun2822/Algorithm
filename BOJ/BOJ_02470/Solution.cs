namespace Algorithm.BOJ.BOJ_02470
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02470/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] acidities = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Array.Sort(acidities);

            int start = 0, end = N - 1;
            int acid1 = 0, acid2 = 0;
            int optSum = int.MaxValue;

            while (start < end)
            {
                int sum = acidities[start] + acidities[end];
                int absSum = Math.Abs(sum);

                if (absSum < optSum)
                {
                    acid1 = acidities[start];
                    acid2 = acidities[end];
                    if ((optSum = absSum) == 0) break;
                }

                if (sum > 0) end--;
                else start++;
            }

            Console.WriteLine($"{acid1} {acid2}");
        }
    }
}
