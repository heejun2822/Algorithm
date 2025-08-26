namespace Algorithm.BOJ.BOJ_16430
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16430/input1.txt",
            "BOJ/BOJ_16430/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] ab = Console.ReadLine()!.Split();
            int A = int.Parse(ab[0]);
            int B = int.Parse(ab[1]);

            Console.WriteLine($"{B - A} {B}");
        }
    }
}
