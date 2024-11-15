namespace Algorithm.BOJ.BOJ_24265
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_24265/input.txt",
        ];

        public static void Run(string[] args)
        {
            long n = long.Parse(Console.ReadLine()!);
            Console.WriteLine(n * (n - 1) / 2);
            Console.WriteLine(2);
        }
    }
}
