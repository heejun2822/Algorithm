namespace Algorithm.BOJ.BOJ_30328
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_30328/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine(n * 4000);
        }
    }
}
