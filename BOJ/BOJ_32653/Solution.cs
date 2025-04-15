namespace Algorithm.BOJ.BOJ_32653
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_32653/input1.txt",
            "BOJ/BOJ_32653/input2.txt",
            "BOJ/BOJ_32653/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] x = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            long minTime = x[0];
            for (int i = 1; i < N; i++) minTime = LCM(minTime, x[i]);

            Console.WriteLine(minTime * 2);

            long LCM(long a, long b) => a * b / GCD(a, b);
            long GCD(long a, long b) => b == 0 ? a : GCD(b, a % b);
        }
    }
}
