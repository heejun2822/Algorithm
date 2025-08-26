namespace Algorithm.BOJ.BOJ_25785
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25785/input1.txt",
            "BOJ/BOJ_25785/input2.txt",
            "BOJ/BOJ_25785/input3.txt",
            "BOJ/BOJ_25785/input4.txt",
        ];

        public static void Run(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            string word = Console.ReadLine()!;

            bool isVowel = Array.Exists(vowels, c => c == word[0]);
            for (int i = 1; i < word.Length; i++)
            {
                if (Array.Exists(vowels, c => c == word[i]) == isVowel)
                {
                    Console.WriteLine("0");
                    return;
                }
                isVowel = !isVowel;
            }
            Console.WriteLine("1");
        }
    }
}
