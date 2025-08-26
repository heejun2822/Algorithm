namespace Algorithm.BOJ.BOJ_18406
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_18406/input1.txt",
            "BOJ/BOJ_18406/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string N = Console.ReadLine()!;

            int sum = 0;
            for (int i = 0; i < N.Length / 2; i++) sum += N[i] - '0';
            for (int i = N.Length / 2; i < N.Length; i++) sum -= N[i] - '0';

            Console.WriteLine(sum == 0 ? "LUCKY" : "READY");
        }
    }
}
