namespace Algorithm.BOJ.BOJ_01545
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01545/input1.txt",
            "BOJ/BOJ_01545/input2.txt",
            "BOJ/BOJ_01545/input3.txt",
            "BOJ/BOJ_01545/input4.txt",
            "BOJ/BOJ_01545/input5.txt",
        ];

        public static void Run(string[] args)
        {
            char[] S = Console.ReadLine()!.ToCharArray();
            Array.Sort(S);

            int l = S.Length / 2 - 1;
            int r = (S.Length + 1) / 2;
            int offset = 0;

            while (r + offset < S.Length && S[l] == S[r + offset])
                offset++;

            while (r + offset < S.Length && S[l] == S[r])
            {
                (S[r], S[r + offset]) = (S[r + offset], S[r]);
                l--;
                r++;
            }

            if (r < S.Length && S[l] == S[r])
                Console.WriteLine(-1);
            else
                Console.WriteLine(string.Join("", S));
        }
    }
}
