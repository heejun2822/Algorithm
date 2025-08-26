namespace Algorithm.BOJ.BOJ_10807
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10807/input1.txt",
            "BOJ/BOJ_10807/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string[] numbers = Console.ReadLine()!.Split();
            string v = Console.ReadLine()!;
            int cnt = numbers.Count(n => n == v);
            Console.WriteLine(cnt);
        }
    }
}
