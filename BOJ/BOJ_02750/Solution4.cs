namespace Algorithm.BOJ.BOJ_02750
{
    public class Solution4
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02750/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] arr = new int[N];
            for (int i = 0; i < N; i++) arr[i] = int.Parse(Console.ReadLine()!);
            // 선택 정렬 (Selection Sort)
            // 시간 복잡도 - Avg: O(n^2) / Worst: O(n^2) / Best: O(n^2)
            // 메모리 - 1
            // 안정성 - X
            for (int idx = 0; idx < N - 1; idx++)
            {
                int minIdx = idx;
                for (int subIdx = idx + 1; subIdx < N; subIdx++)
                {
                    if (arr[subIdx] < arr[minIdx])
                    {
                        minIdx = subIdx;
                    }
                }
                (arr[idx], arr[minIdx]) = (arr[minIdx], arr[idx]);
            }
            Console.WriteLine(string.Join('\n', arr));
        }
    }
}
