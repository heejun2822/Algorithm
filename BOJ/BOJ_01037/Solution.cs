namespace Algorithm.BOJ.BOJ_01037
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01037/input1.txt",
            "BOJ/BOJ_01037/input2.txt",
            "BOJ/BOJ_01037/input3.txt",
            "BOJ/BOJ_01037/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int C = int.Parse(Console.ReadLine()!);
            int[] factors = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int min = factors[0], max = factors[0];
            for (int i = 1; i < C; i++)
            {
                if (factors[i] < min) min = factors[i];
                else if (factors[i] > max) max = factors[i];
            }
            int N = min * max;
            Console.WriteLine(N);
        }
    }
}
