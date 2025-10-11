namespace Algorithm.BOJ.BOJ_06149
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06149/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            int P = int.Parse(input[2]);

            Queue<int> queue = new(K);
            for (int i = 1; i <= K; i++)
                queue.Enqueue(i);

            int M = K / N;
            int[] goodCards = new int[M];

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    goodCards[i] = queue.Dequeue();
                    if (queue.Count == 0) break;
                    for (int _ = 0; _ < P; _++)
                        queue.Enqueue(queue.Dequeue());
                }
            }

            Array.Sort(goodCards);

            System.Text.StringBuilder output = new();
            for (int i = 0; i < M; i++)
                output.AppendLine(goodCards[i].ToString());

            Console.Write(output);
        }
    }
}
