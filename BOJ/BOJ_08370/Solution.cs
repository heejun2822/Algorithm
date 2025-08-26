namespace Algorithm.BOJ.BOJ_08370
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_08370/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int n1 = int.Parse(input[0]);
            int k1 = int.Parse(input[1]);
            int n2 = int.Parse(input[2]);
            int k2 = int.Parse(input[3]);

            Console.WriteLine(n1 * k1 + n2 * k2);
        }
    }
}
