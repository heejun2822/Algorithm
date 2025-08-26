namespace Algorithm.BOJ.BOJ_07579
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_07579/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            int[] memory = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int[] cost = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            // 발상의 전환 : 비활성화되는 메모리의 비용이 최소가 되도록 -> 활성 상태로 남아있는 메모리의 비용이 최대가 되도록
            int maxMemory = memory.Sum() - M;
            int[] maxCost = new int[maxMemory + 1];
            for (int i = 0; i < N; i++)
                for (int j = maxMemory; j >= memory[i]; j--)
                    maxCost[j] = Math.Max(maxCost[j], maxCost[j - memory[i]] + cost[i]);

            Console.WriteLine(cost.Sum() - maxCost[maxMemory]);
        }
    }
}
