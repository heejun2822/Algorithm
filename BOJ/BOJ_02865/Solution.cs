namespace Algorithm.BOJ.BOJ_02865
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02865/input1.txt",
            "BOJ/BOJ_02865/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nmk = Console.ReadLine()!.Split();
            int N = int.Parse(nmk[0]);
            int M = int.Parse(nmk[1]);
            int K = int.Parse(nmk[2]);

            double[] maxStats = new double[N];

            for (int _ = 0; _ < M; _++)
            {
                string[] info = Console.ReadLine()!.Split();
                for (int p = 0; p < N; p++)
                {
                    int i = int.Parse(info[2 * p]);
                    double s = double.Parse(info[2 * p + 1]);
                    maxStats[i - 1] = Math.Max(maxStats[i - 1], s);
                }
            }

            Array.Sort(maxStats, (a, b) => a > b ? -1 : 1);

            double sum = 0;
            for (int i = 0; i < K; i++) sum += maxStats[i];

            Console.WriteLine(sum.ToString("F1"));
        }
    }
}
