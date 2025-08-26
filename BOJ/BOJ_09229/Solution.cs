namespace Algorithm.BOJ.BOJ_09229
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09229/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            string word;
            while ((word = sr.ReadLine()!) != "#")
            {
                string nextWord;
                bool isCorrect = true;
                while ((nextWord = sr.ReadLine()!) != "#")
                {
                    if (!isCorrect) continue;

                    if (word.Length != nextWord.Length)
                    {
                        isCorrect = false;
                        continue;
                    }

                    int cnt = 0;
                    for (int i = 0; i < word.Length; i++)
                        if (word[i] != nextWord[i]) cnt++;
                    if (cnt != 1) isCorrect = false;

                    word = nextWord;
                }

                sw.WriteLine(isCorrect ? "Correct" : "Incorrect");
            }

            sr.Close();
            sw.Close();
        }
    }
}
