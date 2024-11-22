namespace Algorithm.BOJ.BOJ_02751
{
    public class Solution2
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
            // 병합 정렬 (Merge Sort)
            // 시간 복잡도 - Avg: O(nlogn) / Worst: O(nlogn) / Best: O(nlogn)
            // 메모리 - n
            // 안정성 - O
            int[] sortedArr = MergeSort(arr);
            Console.WriteLine(string.Join('\n', sortedArr));
        }

        private static int[] MergeSort(int[] arr)
        {
            if (arr.Length < 2) return arr;

            int mid = arr.Length / 2;
            int[] lowArr = MergeSort(arr.Take(mid).ToArray());
            int[] highArr = MergeSort(arr.Skip(mid).ToArray());

            int[] mergedArr = new int[arr.Length];
            int m = 0, l = 0, h = 0;
            while (l < lowArr.Length && h < highArr.Length)
            {
                if (lowArr[l] < highArr[h]) mergedArr[m++] = lowArr[l++];
                else mergedArr[m++] = highArr[h++];
            }
            while (l < lowArr.Length) mergedArr[m++] = lowArr[l++];
            while (h < highArr.Length) mergedArr[m++] = highArr[h++];

            return mergedArr;
        }
    }
}
