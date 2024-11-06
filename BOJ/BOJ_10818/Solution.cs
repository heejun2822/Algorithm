namespace Algorithm.BOJ.BOJ_10818
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10818/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] numbers = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            Console.WriteLine($"{numbers.Min()} {numbers.Max()}");
        }
    }
}
