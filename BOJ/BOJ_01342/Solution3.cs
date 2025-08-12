namespace Algorithm.BOJ.BOJ_01342
{
    public class Solution3
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01342/input1.txt",
            "BOJ/BOJ_01342/input2.txt",
            "BOJ/BOJ_01342/input3.txt",
            "BOJ/BOJ_01342/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string S = Console.ReadLine()!;

            bool[] used = new bool[S.Length];

            int cnt = 0;
            Search(0, ' ');

            int[] letterCounts = new int[26];
            foreach (char l in S)
                letterCounts[l - 'a']++;
            foreach (int lcnt in letterCounts)
                cnt /= Factorial(lcnt);

            Console.WriteLine(cnt);

            void Search(int idx, char prev)
            {
                if (idx == S.Length)
                {
                    cnt++;
                    return;
                }

                for (int i = 0; i < S.Length; i++)
                {
                    if (!used[i] && S[i] != prev)
                    {
                        used[i] = true;
                        Search(idx + 1, S[i]);
                        used[i] = false;
                    }
                }
            }

            int Factorial(int n)
            {
                return n == 0 ? 1 : n * Factorial(n - 1);
            }
        }
    }
}
