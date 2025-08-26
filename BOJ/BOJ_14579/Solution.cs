namespace Algorithm.BOJ.BOJ_14579
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14579/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] ab = Console.ReadLine()!.Split();
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);

            long value = 1;

            for (int i = a; i <= b; i++)
                value = value * i * (i + 1) / 2 % 14579;

            Console.WriteLine(value);
        }
    }
}
