namespace Algorithm.BOJ.BOJ_02751
{
    public class Solution3
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02751/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] arr = new int[N];
            for (int i = 0; i < N; i++) arr[i] = int.Parse(Console.ReadLine()!);
            // 힙 정렬 (Heap Sort)
            // 시간 복잡도 - Avg: O(nlogn) / Worst: O(nlogn) / Best: O(nlogn)
            // 메모리 - 1
            // 안정성 - X
            for (int idx = N - 1; idx > 0; idx--)
            {
                Heapify(arr, idx);
                (arr[0], arr[idx]) = (arr[idx], arr[0]);
            }
            Console.WriteLine(string.Join('\n', arr));
        }

        private static void Heapify(int[] arr, int lastIdx)
        {
            for (int parentIdx = (lastIdx - 1) / 2; parentIdx >= 0; parentIdx--)
            {
                int maxIdx = parentIdx;

                int leftChildIdx = parentIdx * 2 + 1;
                if (leftChildIdx <= lastIdx && arr[leftChildIdx] > arr[maxIdx]) maxIdx = leftChildIdx;

                int rightChildIdx = parentIdx * 2 + 2;
                if (rightChildIdx <= lastIdx && arr[rightChildIdx] > arr[maxIdx]) maxIdx = rightChildIdx;

                if (maxIdx != parentIdx)
                {
                    (arr[parentIdx], arr[maxIdx]) = (arr[maxIdx], arr[parentIdx]);
                }
            }
        }
    }
}
