namespace Algorithm.BOJ.BOJ_10869
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10869/input.txt",
        ];

        public static void Run(string[] args)
        {
            int[] numbers = (Console.ReadLine() ?? "").Split().Select(n => int.Parse(n)).ToArray();
            Console.WriteLine(numbers[0] + numbers[1]);
            Console.WriteLine(numbers[0] - numbers[1]);
            Console.WriteLine(numbers[0] * numbers[1]);
            Console.WriteLine(numbers[0] / numbers[1]);
            Console.WriteLine(numbers[0] % numbers[1]);
        }
    }
}
