namespace Algorithm.BOJ.BOJ_15829
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15829/input1.txt",
            "BOJ/BOJ_15829/input2.txt",
            "BOJ/BOJ_15829/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int L = int.Parse(Console.ReadLine()!);
            string a = Console.ReadLine()!;
            int r = 31;
            int M = 1234567891;

            long H = 0;
            long rPow = 1;
            for (int i = 0; i < L; i++)
            {
                H += (a[i] - 'a' + 1) * rPow;
                rPow = rPow * r % M;
            }
            H %= M;

            Console.WriteLine(H);
        }
    }
}
