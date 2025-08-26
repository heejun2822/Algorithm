namespace Algorithm.BOJ.BOJ_25183
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25183/input1.txt",
            "BOJ/BOJ_25183/input2.txt",
            "BOJ/BOJ_25183/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string S = Console.ReadLine()!;

            char c = S[0];
            int len = 1;
            for (int i = 1; i < N; i++)
            {
                if (Math.Abs(c - S[i]) == 1)
                {
                    if (++len == 5)
                    {
                        Console.WriteLine("YES");
                        return;
                    }
                }
                else len = 1;
                c = S[i];
            }
            Console.WriteLine("NO");
        }
    }
}
