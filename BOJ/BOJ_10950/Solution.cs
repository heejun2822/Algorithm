namespace Algorithm.BOJ.BOJ_10950
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10950/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < T; i++)
            {
                string[] numbers = Console.ReadLine()!.Split();
                int A = int.Parse(numbers[0]);
                int B = int.Parse(numbers[1]);
                Console.WriteLine(A + B);
            }
        }
    }
}
