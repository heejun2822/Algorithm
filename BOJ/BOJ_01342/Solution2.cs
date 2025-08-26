namespace Algorithm.BOJ.BOJ_01342
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01342/input1.txt",
            "BOJ/BOJ_01342/input2.txt",
            "BOJ/BOJ_01342/input3.txt",
            "BOJ/BOJ_01342/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string S = Console.ReadLine()!;

            int[] letterCounts = new int[26];

            foreach (char l in S)
                letterCounts[l - 'a']++;

            int cnt = 0;
            Search(0, ' ');

            Console.WriteLine(cnt);

            void Search(int idx, int prevL)
            {
                if (idx == S.Length)
                {
                    cnt++;
                    return;
                }

                for (int l = 0; l < 26; l++)
                {
                    if (letterCounts[l] > 0 && l != prevL)
                    {
                        letterCounts[l]--;
                        Search(idx + 1, l);
                        letterCounts[l]++;
                    }
                }
            }
        }
    }
}
