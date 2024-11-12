namespace Algorithm.BOJ.BOJ_02581
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02581/input1.txt",
            "BOJ/BOJ_02581/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int M = int.Parse(Console.ReadLine()!);
            int N = int.Parse(Console.ReadLine()!);
            int sum = 0;
            int min = 0;
            for (int num = M; num <= N; num++)
            {
                if (IsPrimary(num))
                {
                    sum += num;
                    if (min == 0) min = num;
                }
            }
            if (sum == 0)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(sum);
                Console.WriteLine(min);
            }
        }

        private static bool IsPrimary(int num)
        {
            if (num == 1) return false;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
