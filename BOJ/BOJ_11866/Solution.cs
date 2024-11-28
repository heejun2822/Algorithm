namespace Algorithm.BOJ.BOJ_11866
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11866/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);

            Queue<int> queue = new(Enumerable.Range(1, N));
            int[] orders = new int[N];
            for (int itr = 1; itr <= N * K; itr++)
            {
                if (itr % K == 0) orders[itr / K - 1] = queue.Dequeue();
                else queue.Enqueue(queue.Dequeue());
            }

            Console.WriteLine($"<{string.Join(", ", orders)}>");
        }
    }
}
