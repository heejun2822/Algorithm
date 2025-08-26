namespace Algorithm.BOJ.BOJ_11720
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11720/input1.txt",
            "BOJ/BOJ_11720/input2.txt",
            "BOJ/BOJ_11720/input3.txt",
            "BOJ/BOJ_11720/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string numbers = Console.ReadLine()!;
            int sum = numbers.Select(n => (int)Char.GetNumericValue(n)).Sum();
            Console.WriteLine(sum);
        }
    }
}
