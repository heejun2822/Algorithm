namespace Algorithm.BOJ.BOJ_25957
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25957/input1.txt",
            "BOJ/BOJ_25957/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);
            Dictionary<string, string>[,] wordsMap = new Dictionary<string, string>[26, 27];

            for (int _ = 0; _ < N; _++)
            {
                string word = sr.ReadLine()!;

                (int first, int last, string center) = DivideWord(word);
                wordsMap[first, last] ??= new();
                wordsMap[first, last].Add(center, word);
            }

            int M = int.Parse(sr.ReadLine()!);
            string[] S = sr.ReadLine()!.Split();

            System.Text.StringBuilder output = new();

            for (int i = 0; i < M; i++)
            {
                (int first, int last, string center) = DivideWord(S[i]);
                output.Append(wordsMap[first, last][center]).Append(' ');
            }

            sw.WriteLine(output);

            sr.Close();
            sw.Close();

            (int first, int last, string center) DivideWord(string word)
            {
                int first = word[0] - 'a';
                int last = 26;
                string center = "";

                if (word.Length >= 2)
                {
                    last = word[^1] - 'a';

                    char[] arr = new char[word.Length - 2];
                    for (int i = 0; i < arr.Length; i++)
                        arr[i] = word[i + 1];
                    Array.Sort(arr);
                    center = string.Join("", arr);
                }

                return (first, last, center);
            }
        }
    }
}
