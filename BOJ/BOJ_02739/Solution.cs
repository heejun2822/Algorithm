namespace Algorithm.BOJ.BOJ_02739
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02739/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            for (int i = 1; i <= 9; i++)
            {
                Console.WriteLine($"{N} * {i} = {N * i}");
            }
        }
    }
}
