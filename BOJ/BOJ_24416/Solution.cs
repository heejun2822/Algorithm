namespace Algorithm.BOJ.BOJ_24416
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_24416/input1.txt",
            "BOJ/BOJ_24416/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            int[] fibonacci = new int[n];
            fibonacci[0] = fibonacci[1] = 1;
            for (int i = 2; i < n; i++) fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];

            Console.WriteLine($"{fibonacci[n - 1]} {n - 2}");
        }
    }
}
