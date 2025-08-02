namespace Algorithm.BOJ.BOJ_13699
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_13699/input1.txt",
            "BOJ/BOJ_13699/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            long[] t = new long[n + 1];
            t[0] = 1;

            for (int i = 1; i <= n; i++)
                for (int j = 0; j < i; j++)
                    t[i] += t[j] * t[i - 1 - j];

            Console.WriteLine(t[n]);
        }
    }
}
