namespace Algorithm.BOJ.BOJ_02223
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02223/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] txm = Console.ReadLine()!.Split();
            int t = int.Parse(txm[0]);
            int x = int.Parse(txm[1]);
            int m = int.Parse(txm[2]);

            int cnt = t;

            for (int _ = 0; _ < m; _++)
            {
                string[] ds = Console.ReadLine()!.Split();
                int d = int.Parse(ds[0]);
                int s = int.Parse(ds[1]);
                cnt = Math.Min(cnt, (d - 1) / s);
            }

            if (cnt > 0) cnt += (t - cnt) / 2;

            Console.WriteLine(x * cnt);
        }
    }
}
