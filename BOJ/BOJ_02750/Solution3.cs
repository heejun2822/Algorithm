namespace Algorithm.BOJ.BOJ_02750
{
    public class Solution3
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
            // 버블 정렬 (Bubble Sort)
            // 시간 복잡도 - Avg: O(n^2) / Worst: O(n^2) / Best: O(n)
            // 메모리 - 1
            // 안정성 - O
            for (int itr = 0; itr < N - 1; itr++)
            {
                int cnt = 0;
                for (int idx = 0; idx < N - 1 - itr; idx++)
                {
                    if (arr[idx] > arr[idx + 1])
                    {
                        (arr[idx], arr[idx + 1]) = (arr[idx + 1], arr[idx]);
                        cnt++;
                    }
                }
                if (cnt == 0) break;
            }
            Console.WriteLine(string.Join('\n', Array.ConvertAll(arr, num => num.ToString())));
        }
    }
}
