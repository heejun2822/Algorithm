namespace Algorithm.BOJ.BOJ_01300
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01300/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int k = int.Parse(Console.ReadLine()!);

            int low = 1, high = k;  // B[k] <= k 이기 때문에 상한은 k
            while (low < high)
            {
                int mid = (low + high) / 2;
                int cnt = 0;
                for (int i = 1; i <= N; i++)
                {
                    cnt += Math.Min(mid / i, N);    // 각 행에서 mid보다 작거나 같은 수의 개수
                    if (cnt >= k) break;
                }
                if (cnt >= k) high = mid;
                else low = mid + 1;
            }

            Console.WriteLine(low);
        }
    }
}
