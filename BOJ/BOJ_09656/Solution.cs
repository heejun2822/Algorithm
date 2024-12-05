namespace Algorithm.BOJ.BOJ_09656
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09656/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            Console.WriteLine(N % 2 == 0 ? "SK" : "CY");
        }
    }
}
