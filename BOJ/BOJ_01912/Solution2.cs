namespace Algorithm.BOJ.BOJ_01912
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01912/input1.txt",
            "BOJ/BOJ_01912/input2.txt",
            "BOJ/BOJ_01912/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] sqn = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int[] acc = new int[n];
            acc[0] = sqn[0];
            int max = acc[0];
            int minAcc = Math.Min(acc[0], 0);
            for (int i = 1; i < n; i++)
            {
                acc[i] = acc[i - 1] + sqn[i];
                max = Math.Max(max, acc[i] - minAcc);
                minAcc = Math.Min(minAcc, acc[i]);
            }

            Console.WriteLine(max);
        }
    }
}
