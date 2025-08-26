namespace Algorithm.BOJ.BOJ_20003
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20003/input1.txt",
            "BOJ/BOJ_20003/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            (int A, int B)[] prices = new (int, int)[N];
            long lcmB = 1;

            for (int i = 0; i < N; i++)
            {
                string[] ab = Console.ReadLine()!.Split();
                int A = int.Parse(ab[0]);
                int B = int.Parse(ab[1]);

                prices[i] = (A, B);
                lcmB = lcmB * B / GCD(lcmB, B);
            }

            long gcdA = prices[0].A * (lcmB / prices[0].B);

            for (int i = 1; i < N; i++)
            {
                gcdA = GCD(gcdA, prices[i].A * (lcmB / prices[i].B));
            }

            long d = GCD(gcdA, lcmB);

            Console.WriteLine($"{gcdA / d} {lcmB / d}");

            long GCD(long a, long b)
            {
                return b == 0 ? a : GCD(b, a % b);
            }
        }
    }
}
