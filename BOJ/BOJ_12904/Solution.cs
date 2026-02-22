namespace Algorithm.BOJ.BOJ_12904
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12904/input1.txt",
            "BOJ/BOJ_12904/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string S = Console.ReadLine()!;
            string T = Console.ReadLine()!;

            int l = 0, r = T.Length - 1;
            bool right = true;

            while (r - l + 1 > S.Length)
                if ((right ? T[r--] : T[l++]) == 'B')
                    right = !right;

            bool success = true;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] != (right ? T[l + i] : T[r - i]))
                {
                    success = false;
                    break;
                }
            }

            Console.WriteLine(success ? 1 : 0);
        }
    }
}
