namespace Algorithm.BOJ.BOJ_20920
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20920/input1.txt",
            "BOJ/BOJ_20920/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            string[] nm = sr.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            Dictionary<string, int> counts = new();
            for (int _ = 0; _ < N; _++)
            {
                string word = sr.ReadLine()!;
                if (word.Length < M) continue;
                if (!counts.TryAdd(word, 1)) counts[word]++;
            }

            foreach ((string word, int cnt) in counts.OrderByDescending(e => e.Value).ThenByDescending(e => e.Key.Length).ThenBy(e => e.Key)) sw.WriteLine(word);

            sr.Close();
            sw.Close();
        }
    }
}
