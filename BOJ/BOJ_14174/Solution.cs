namespace Algorithm.BOJ.BOJ_14174
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14174/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int[] totalCnt = new int[26];
            int[] word1Cnt = new int[26];
            int[] word2Cnt = new int[26];

            for (int _ = 0; _ < N; _++)
            {
                Array.Fill(word1Cnt, 0);
                Array.Fill(word2Cnt, 0);

                string[] words = Console.ReadLine()!.Split();

                foreach (char c in words[0])
                    word1Cnt[c - 'a']++;
                foreach (char c in words[1])
                    word2Cnt[c - 'a']++;

                for (int i = 0; i < 26; i++)
                    totalCnt[i] += Math.Max(word1Cnt[i], word2Cnt[i]);
            }

            foreach (int cnt in totalCnt)
                Console.WriteLine(cnt);
        }
    }
}
