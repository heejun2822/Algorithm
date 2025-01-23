namespace Algorithm.BOJ.BOJ_07579
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
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

            // 발상의 전환 : m만큼의 메모리를 비활성화하는데 필요한 최소 비용 DP -> c만큼의 비용을 들여 비활성화할 수 있는 최대 메모리 DP
            int maxCost = cost.Sum();
            int[] maxMemory = new int[maxCost + 1];
            for (int i = 0; i < N; i++)
                for (int j = maxCost; j >= cost[i]; j--)
                    maxMemory[j] = Math.Max(maxMemory[j], maxMemory[j - cost[i]] + memory[i]);

            for (int c = 0; c <= maxCost; c++)
                if (maxMemory[c] >= M)
                {
                    Console.WriteLine(c);
                    break;
                }
        }
    }
}
