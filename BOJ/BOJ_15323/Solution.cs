namespace Algorithm.BOJ.BOJ_15323
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15323/input1.txt",
            "BOJ/BOJ_15323/input2.txt",
            "BOJ/BOJ_15323/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            string[] kn = sr.ReadLine()!.Split();
            int K = int.Parse(kn[0]);
            int N = int.Parse(kn[1]);

            List<string>[] words = new List<string>[26];
            for (int _ = 0; _ < K; _++)
            {
                string word = sr.ReadLine()!;
                words[word[0] - 'a'] ??= new();
                words[word[0] - 'a'].Add(word);
            }
            for (int i = 0; i < 26; i++) words[i]?.Sort();

            int[] counts = new int[26];
            for (int _ = 0; _ < N; _++)
            {
                int letter = char.Parse(sr.ReadLine()!) - 'a';
                sw.WriteLine(words[letter][counts[letter]]);
                counts[letter] = (counts[letter] + 1) % words[letter].Count;
            }

            sr.Close();
            sw.Close();
        }
    }
}
