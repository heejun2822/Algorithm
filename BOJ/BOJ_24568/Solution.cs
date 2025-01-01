namespace Algorithm.BOJ.BOJ_24568
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_24568/input1.txt",
            "BOJ/BOJ_24568/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int R = int.Parse(Console.ReadLine()!);
            int S = int.Parse(Console.ReadLine()!);
            Console.WriteLine(8 * R + 3 * S - 28);
        }
    }
}
