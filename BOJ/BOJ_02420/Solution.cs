namespace Algorithm.BOJ.BOJ_02420
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02420/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            long N = long.Parse(input[0]);
            long M = long.Parse(input[1]);
            Console.WriteLine(Math.Abs(N - M));
        }
    }
}
