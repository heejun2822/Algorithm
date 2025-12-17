namespace Algorithm.BOJ.BOJ_16360
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16360/input1.txt",
            "BOJ/BOJ_16360/input2.txt",
        ];

        public static void Run(string[] args)
        {
            (string en, string la)[] suffixes =
            {
                ("a", "as"), ("i", "ios"), ("y","ios"), ("l", "les"), ("n", "anes"), ("ne", "anes"),
                ("o", "os"), ("r", "res"), ("t", "tas"), ("u", "us"), ("v", "ves"), ("w", "was"), ("", "us")
            };

            int n = int.Parse(Console.ReadLine()!);

            while (n-- > 0)
            {
                string word = Console.ReadLine()!;

                foreach ((string en, string la) in suffixes)
                {
                    if (word.EndsWith(en))
                    {
                        Console.WriteLine(word[..(word.Length - en.Length)] + la);
                        break;
                    }
                }
            }
        }
    }
}
