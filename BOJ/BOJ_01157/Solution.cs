namespace Algorithm.BOJ.BOJ_01157
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01157/input1.txt",
            "BOJ/BOJ_01157/input2.txt",
            "BOJ/BOJ_01157/input3.txt",
            "BOJ/BOJ_01157/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string word = Console.ReadLine()!.ToUpper();
            Dictionary<char, int> counts = new();
            foreach (char c in word)
            {
                if (!counts.TryAdd(c, 1)) counts[c]++;
            }
            char answer = '?';
            int max = 0;
            foreach ((char c, int cnt) in counts)
            {
                if (cnt < max) continue;
                answer = cnt > max ? c : '?';
                max = cnt;
            }
            Console.WriteLine(answer);
        }
    }
}
