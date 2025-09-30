namespace Algorithm.BOJ.BOJ_02247
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02247/input1.txt",
            "BOJ/BOJ_02247/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            Console.WriteLine(CSOD(n) % 1_000_000);

            long CSOD(int n)
            {
                long result = 0;

                int lim = n / 2;

                for (int i = 2; i <= lim; i++)
                    result += (n / i - 1) * i;

                return result;
            }
        }
    }
}
