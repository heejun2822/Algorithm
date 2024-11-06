namespace Algorithm.BOJ.BOJ_18108
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_18108/input.txt",
        ];

        public static void Run(string[] args)
        {
            string year = Console.ReadLine() ?? "";
            Console.WriteLine(int.Parse(year) - 543);
        }
    }
}
