namespace Algorithm.BOJ.BOJ_04583
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_04583/input.txt",
        ];

        private static HashSet<char> mirrorChars = new() {'b', 'd', 'p', 'q', 'i', 'o', 'v', 'w', 'x'};

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            while (true)
            {
                string word = sr.ReadLine()!;
                if (word == "#") break;

                PrintMirrored(word, sw);
            }

            sr.Close();
            sw.Close();
        }

        private static void PrintMirrored(string word, StreamWriter sw)
        {
            foreach (char c in word)
                if (!mirrorChars.Contains(c))
                {
                    sw.WriteLine("INVALID");
                    return;
                }

            for (int i = word.Length - 1; i >= 0; i--)
                sw.Write(
                    word[i] switch
                    {
                        'b' => 'd',
                        'd' => 'b',
                        'p' => 'q',
                        'q' => 'p',
                        _ => word[i],
                    }
                );
            sw.Write('\n');
        }
    }
}
