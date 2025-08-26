namespace Algorithm.BOJ.BOJ_09933
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09933/input1.txt",
            "BOJ/BOJ_09933/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string[] words = new string[N];

            for (int i = 0; i < N; i++)
            {
                words[i] = Console.ReadLine()!;

                for (int j = 0; j <= i; j++)
                {
                    if (IsBackward(words[i], words[j]))
                    {
                        int len = words[i].Length;
                        Console.WriteLine($"{len} {words[i][len / 2]}");
                        return;
                    }
                }
            }

            bool IsBackward(string A, string B)
            {
                if (A.Length != B.Length)
                    return false;

                for (int i = 0; i < A.Length; i++)
                    if (A[i] != B[^(i + 1)])
                        return false;

                return true;
            }
        }
    }
}
