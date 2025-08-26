namespace Algorithm.BOJ.BOJ_20920
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
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

            string[] words = counts.Keys.ToArray();
            Array.Sort(words, (a, b) =>
                counts[a] != counts[b] ? counts[b] - counts[a] :
                a.Length != b.Length ? b.Length - a.Length :
                a.CompareTo(b)
            );
            foreach (string word in words) sw.WriteLine(word);

            sr.Close();
            sw.Close();
        }
    }
}
