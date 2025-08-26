namespace Algorithm.BOJ.BOJ_20359
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20359/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int o = n;
            int p = 0;
            while (o % 2 == 0)
            {
                o /= 2;
                p++;
            }
            Console.WriteLine($"{o} {p}");
        }
    }
}
