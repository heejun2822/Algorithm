namespace Algorithm.BOJ.BOJ_02579
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02579/input.txt",
        ];

        public static void Run(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine()!);
            int[] stairs = new int[cnt + 1];
            for (int i = 1; i <= cnt; i++) stairs[i] = int.Parse(Console.ReadLine()!);

            int[,] acc = new int[cnt + 1, 2];
            acc[1, 0] = acc[1, 1] = stairs[1];
            for (int i = 2; i <= cnt; i++)
            {
                acc[i, 0] = acc[i - 1, 1] + stairs[i];
                acc[i, 1] = Math.Max(acc[i - 2, 0], acc[i - 2, 1]) + stairs[i];
            }

            Console.WriteLine(Math.Max(acc[cnt, 0], acc[cnt, 1]));
        }
    }
}
