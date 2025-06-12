namespace Algorithm.BOJ.BOJ_32437
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_32437/input1.txt",
            "BOJ/BOJ_32437/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int a = 1, b = 1;

            for (int _ = 0; _ < N; _++) (a, b) = (b, a + b);

            Console.WriteLine(a);
        }
    }
}
