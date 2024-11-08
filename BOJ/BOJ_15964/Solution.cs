namespace Algorithm.BOJ.BOJ_15964
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15964/input1.txt",
            "BOJ/BOJ_15964/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] numbers = Console.ReadLine()!.Split();
            long A = long.Parse(numbers[0]);
            long B = long.Parse(numbers[1]);
            Console.WriteLine((A + B) * (A - B));
        }
    }
}
