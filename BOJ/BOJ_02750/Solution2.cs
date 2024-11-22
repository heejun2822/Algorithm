namespace Algorithm.BOJ.BOJ_02750
{
    public class Solution2
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
            // 삽입 정렬 (Insertion Sort)
            // 시간 복잡도 - Avg: O(n^2) / Worst: O(n^2) / Best: O(n)
            // 메모리 - 1
            // 안정성 - O
            for (int idx = 1; idx < N; idx++)
            {
                int target = arr[idx];
                int subIdx = idx - 1;
                while (subIdx >= 0 && arr[subIdx] > target)
                {
                    arr[subIdx + 1] = arr[subIdx];
                    subIdx--;
                }
                arr[subIdx + 1] = target;
            }
            Console.WriteLine(string.Join('\n', Array.ConvertAll(arr, num => num.ToString())));
        }
    }
}
