namespace Algorithm.BOJ.BOJ_25705
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25705/input1.txt",
            "BOJ/BOJ_25705/input2.txt",
            "BOJ/BOJ_25705/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string alphabets = Console.ReadLine()!;
            int M = int.Parse(Console.ReadLine()!);
            string S = Console.ReadLine()!;

            int cnt = 0;
            foreach (char c in S)
            {
                for (int _ = 0; _ < N; _++)
                    if (alphabets[(++cnt - 1) % N] == c) goto Next;
                cnt = -1;
                break;
                Next:;
            }
            Console.WriteLine(cnt);
        }
    }
}
