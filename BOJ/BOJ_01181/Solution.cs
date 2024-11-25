namespace Algorithm.BOJ.BOJ_01181
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01181/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());
            int N = int.Parse(sr.ReadLine()!);
            string[] words = new string[N];
            for (int i = 0; i < N; i++) words[i] = sr.ReadLine()!;
            Array.Sort(words, (a, b) => a.Length != b.Length ? a.Length - b.Length : a.CompareTo(b));
            string prevWord = "";
            foreach (string word in words)
            {
                if (word == prevWord) continue;
                sw.WriteLine(word);
                prevWord = word;
            }
            sr.Close();
            sw.Close();
        }
    }
}
