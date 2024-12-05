namespace Algorithm.BOJ.BOJ_16394
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_16394/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            Console.WriteLine(N - 1946);
        }
    }
}
