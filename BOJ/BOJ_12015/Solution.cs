namespace Algorithm.BOJ.BOJ_12015
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12015/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string[] A = Console.ReadLine()!.Split();

            List<int> LIS = new() { int.Parse(A[0]) };
            for (int i = 1; i < N; i++)
            {
                int num = int.Parse(A[i]);

                if (num > LIS[^1])
                {
                    LIS.Add(num);
                }
                else if (num < LIS[^1])
                {
                    int low = 0, high = LIS.Count - 1;
                    while (low < high)
                    {
                        int mid = (low + high) / 2;
                        if (LIS[mid] < num) low = mid + 1;
                        else if (LIS[mid] > num) high = mid;
                        else break;
                    }
                    if (low < high) continue;
                    LIS[low] = num;
                }
            }

            Console.WriteLine(LIS.Count);
        }
    }
}
