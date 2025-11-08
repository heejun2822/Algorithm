namespace Algorithm.BOJ.BOJ_25276
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25276/input1.txt",
            "BOJ/BOJ_25276/input2.txt",
            "BOJ/BOJ_25276/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string S1 = Console.ReadLine()!;
            string S2 = Console.ReadLine()!;

            int cnt = S1.Length + S2.Length;

            int idx = 0;
            while (idx < S1.Length && idx < S2.Length && S1[idx] == S2[idx])
            {
                cnt -= 2;
                idx++;
            }

            Console.WriteLine(cnt);
        }
    }
}
