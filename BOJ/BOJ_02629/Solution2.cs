namespace Algorithm.BOJ.BOJ_02629
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02629/input1.txt",
            "BOJ/BOJ_02629/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int weightCnt = int.Parse(Console.ReadLine()!);
            int[] weights = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int marbleCnt = int.Parse(Console.ReadLine()!);
            int[] marbles = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            bool[] memo = new bool[weights.Sum() + 1];
            Queue<int> temp = new();
            int maxWeight = 0;

            for (int i = 0; i < weightCnt; i++)
            {
                for (int w = 0; w <= maxWeight; w++)
                {
                    if (!memo[w]) continue;
                    temp.Enqueue(w + weights[i]);
                    temp.Enqueue(Math.Abs(w - weights[i]));
                }

                memo[weights[i]] = true;
                while (temp.Count > 0) memo[temp.Dequeue()] = true;

                maxWeight += weights[i];
            }

            for (int i = 0; i < marbleCnt; i++)
            {
                bool isPossible = marbles[i] < memo.Length && memo[marbles[i]];
                Console.Write(isPossible ? "Y " : "N ");
            }
            Console.Write("\n");
        }
    }
}
