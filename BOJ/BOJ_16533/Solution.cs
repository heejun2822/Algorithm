namespace Algorithm.BOJ.BOJ_16533
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_16533/input1.txt",
            "BOJ/BOJ_16533/input2.txt",
            "BOJ/BOJ_16533/input3.txt",
            "BOJ/BOJ_16533/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] C = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int minCnt = 1;

            for (int i = 1; i < N; i++)
                if (C[i] > C[i - 1])
                    minCnt++;

            Console.WriteLine(minCnt);
        }
    }
}
