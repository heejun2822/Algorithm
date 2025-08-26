namespace Algorithm.BOJ.BOJ_02629
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
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

            int[] memo = Enumerable.Repeat(-1, weights.Sum() + 1).ToArray();
            memo[0] = 0;
            int maxWeight = 0;

            for (int i = 0; i < weightCnt; i++)
            {
                for (int w = 0; w <= maxWeight; w++)
                {
                    if (memo[w] == -1 || memo[w] == i + 1) continue;

                    int nw = w + weights[i];
                    if (memo[nw] == -1) memo[nw] = i + 1;
                    nw = Math.Abs(w - weights[i]);
                    if (memo[nw] == -1) memo[nw] = i + 1;
                }

                maxWeight += weights[i];
            }

            for (int i = 0; i < marbleCnt; i++)
            {
                bool isPossible = marbles[i] < memo.Length && memo[marbles[i]] >= 0;
                Console.Write(isPossible ? "Y " : "N ");
            }
            Console.Write("\n");
        }
    }
}
