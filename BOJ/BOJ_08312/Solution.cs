namespace Algorithm.BOJ.BOJ_08312
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_08312/input1.txt",
            "BOJ/BOJ_08312/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nmp = Console.ReadLine()!.Split();
            int n = int.Parse(nmp[0]);
            int m = int.Parse(nmp[1]);
            int p = int.Parse(nmp[2]);

            long cnt = 0;

            for (int w = 1; w <= n; w++)
                for (int h = 1; h <= m; h++)
                    if (2 * (w + h) >= p)
                        cnt += (n - w + 1) * (m - h + 1);

            Console.WriteLine(cnt);
        }
    }
}
