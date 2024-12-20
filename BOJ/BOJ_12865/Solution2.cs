namespace Algorithm.BOJ.BOJ_12865
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_12865/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            int[] maxValues = new int[K + 1];
            for (int i = 0; i < N; i++)
            {
                string[] info = Console.ReadLine()!.Split();
                int W = int.Parse(info[0]);
                int V = int.Parse(info[1]);
                for (int j = K; j >= W; j--)
                    maxValues[j] = Math.Max(maxValues[j], maxValues[j - W] + V);
            }

            Console.WriteLine(maxValues[K]);
        }
    }
}
