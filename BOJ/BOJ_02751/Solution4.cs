namespace Algorithm.BOJ.BOJ_02751
{
    public class Solution4 : SolutionBOJ<Solution4>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02751/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] arr = new int[N];
            for (int i = 0; i < N; i++) arr[i] = int.Parse(Console.ReadLine()!);
            // 퀵 정렬 (Quick Sort)
            // 시간 복잡도 - Avg: O(nlogn) / Worst: O(n^2) / Best: O(nlogn)
            // 메모리 - Avg: logn / Worst: n
            // 안정성 - X
            QuickSort(arr, 0, N - 1);
            Console.WriteLine(string.Join('\n', arr));
        }

        private static void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right) return;

            int pivot = arr[(left + right) / 2];
            int l = left, r = right;
            while (l <= r)
            {
                while (arr[l] < pivot) l++;
                while (arr[r] > pivot) r--;
                if (l <= r)
                {
                    (arr[l], arr[r]) = (arr[r], arr[l]);
                    l++;
                    r--;
                }
            }

            QuickSort(arr, left, r);
            QuickSort(arr, l, right);
        }
    }
}
