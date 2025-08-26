namespace Algorithm.BOJ.BOJ_01316
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01316/input1.txt",
            "BOJ/BOJ_01316/input2.txt",
            "BOJ/BOJ_01316/input3.txt",
            "BOJ/BOJ_01316/input4.txt",
            "BOJ/BOJ_01316/input5.txt",
            "BOJ/BOJ_01316/input6.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                string word = Console.ReadLine()!;
                if (IsGroupWord(word)) cnt++;
            }
            Console.WriteLine(cnt);
        }

        private static bool IsGroupWord(string word)
        {
            bool[] memo = new bool[26];
            char prevChar = ' ';
            foreach (char c in word)
            {
                if (c == prevChar) continue;
                if (memo[c - 'a']) return false;
                memo[c - 'a'] = true;
                prevChar = c;
            }
            return true;
        }
    }
}
