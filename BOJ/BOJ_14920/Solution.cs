namespace Algorithm.BOJ.BOJ_14920
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14920/input1.txt",
            "BOJ/BOJ_14920/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int C = int.Parse(Console.ReadLine()!);
            int n = 1;

            while (C != 1)
            {
                C = C % 2 == 0 ? C / 2 : 3 * C + 1;
                n++;
            }

            Console.WriteLine(n);
        }
    }
}
