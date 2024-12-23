namespace Algorithm.BOJ.BOJ_02559
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02559/input1.txt",
            "BOJ/BOJ_02559/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);
            int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            for (int i = 1; i < N; i++) arr[i] += arr[i - 1];

            int max = arr[K - 1];
            for (int i = K; i < N; i++)
            {
                int sum = arr[i] - arr[i - K];
                if (sum > max) max = sum;
            }

            Console.WriteLine(max);
        }
    }
}
