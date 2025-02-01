namespace Algorithm.BOJ.BOJ_31432
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_31432/input.txt",
        ];

        private static int N;
        private static int[] d = {};

        public static void Run(string[] args)
        {
            N = int.Parse(Console.ReadLine()!);
            d = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            long num = 0;
            for (int p = 1; p <= 11; p++)
            {
                if (FindCompositeNumber(p, ref num))
                {
                    Console.WriteLine("YES");
                    Console.WriteLine(num);
                    return;
                }
            }
            Console.WriteLine("NO");
        }

        private static bool FindCompositeNumber(int p, ref long num)
        {
            if (p == 0) return IsCompositeNumber(num);

            num *= 10;
            for (int i = 0; i < N; i++)
            {
                num += d[i];
                if (FindCompositeNumber(p - 1, ref num)) return true;
                num -= d[i];
            }
            num /= 10;

            return false;
        }

        private static bool IsCompositeNumber(long num)
        {
            if (num == 0 || num == 1) return true;

            int limit = (int)Math.Sqrt(num);
            for (int i = 2; i <= limit; i++)
            {
                if (num % i == 0) return true;
            }
            return false;
        }
    }
}
