namespace Algorithm.BOJ.BOJ_25870
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25870/input1.txt",
            "BOJ/BOJ_25870/input2.txt",
            "BOJ/BOJ_25870/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string str = Console.ReadLine()!;
            int[] counts = new int[26];
            foreach (char c in str) counts[c - 'a']++;
            int even = 0, odd = 0;
            foreach (int cnt in counts)
            {
                if (cnt == 0) continue;
                if (cnt % 2 == 0) even++;
                else odd++;
            }
            int answer = 2;
            if (even == 0) answer = 1;
            else if (odd == 0) answer = 0;
            Console.WriteLine(answer);
        }
    }
}
