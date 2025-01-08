namespace Algorithm.BOJ.BOJ_02110
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02110/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nc = Console.ReadLine()!.Split();
            int N = int.Parse(nc[0]);
            int C = int.Parse(nc[1]);
            int[] x = new int[N];
            for (int i = 0; i < N; i++) x[i] = int.Parse(Console.ReadLine()!);
            Array.Sort(x);

            int low = 1, high = (x[N - 1] - x[0]) / (C - 1);
            while (low < high)
            {
                int mid = (low + high + 1) / 2;

                int cnt = 1;
                int prevX = x[0];
                for (int i = 1; i < N; i++)
                {
                    if (x[i] - prevX >= mid)
                    {
                        if (++cnt >= C) break;
                        prevX = x[i];
                    }
                }

                if (cnt >= C) low = mid;
                else high = mid - 1;
            }

            Console.WriteLine(high);
        }
    }
}
