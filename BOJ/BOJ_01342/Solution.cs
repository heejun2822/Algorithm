namespace Algorithm.BOJ.BOJ_01342
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
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

            Dictionary<char, int> letterCounts = new();

            foreach (char l in S)
                if (!letterCounts.TryAdd(l, 1))
                    letterCounts[l]++;

            int cnt = 0;
            Search(0, ' ');

            Console.WriteLine(cnt);

            void Search(int idx, char prevL)
            {
                if (idx == S.Length)
                {
                    cnt++;
                    return;
                }

                foreach (char l in letterCounts.Keys)
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
