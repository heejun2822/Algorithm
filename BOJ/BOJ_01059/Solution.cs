namespace Algorithm.BOJ.BOJ_01059
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01059/input1.txt",
            "BOJ/BOJ_01059/input2.txt",
            "BOJ/BOJ_01059/input3.txt",
            "BOJ/BOJ_01059/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int L = int.Parse(Console.ReadLine()!);
            int[] S = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int n = int.Parse(Console.ReadLine()!);

            Array.Sort(S);

            int l = 0, r = L - 1;

            while (l < r)
            {
                int m = (l + r) / 2;
                if (S[m] >= n)
                    r = m;
                else
                    l = m + 1;
            }

            if (S[r] == n)
                Console.WriteLine(0);
            else if (r == 0)
                Console.WriteLine(n * (S[r] - n) - 1);
            else
                Console.WriteLine((n - S[r - 1]) * (S[r] - n) - 1);
        }
    }
}
