namespace Algorithm.BOJ.BOJ_33883
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_33883/input1.txt",
            "BOJ/BOJ_33883/input2.txt",
            "BOJ/BOJ_33883/input3.txt",
            "BOJ/BOJ_33883/input4.txt",
        ];

        public static void Run(string[] args)
        {
            HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };

            string S = Console.ReadLine()!;

            int answer = -1;
            int count = (vowels.Contains(S[^1]) || S[^1] == 'n' || S[^1] == 's') ? 2 : 1;

            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (vowels.Contains(S[i]) && --count == 0)
                {
                    answer = i + 1;
                    break;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
