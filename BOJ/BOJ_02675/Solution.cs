namespace Algorithm.BOJ.BOJ_02675
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02675/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            System.Text.StringBuilder answer = new();
            for (int i = 0; i < T; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                int R = int.Parse(input[0]);
                string S = input[1];
                System.Text.StringBuilder P = new();
                for (int j = 0; j < S.Length; j++)
                {
                    for (int k = 0; k < R; k++) P.Append(S[j]);
                }
                answer.AppendLine(P.ToString());
            }
            Console.WriteLine(answer);
        }
    }
}
