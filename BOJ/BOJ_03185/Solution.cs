namespace Algorithm.BOJ.BOJ_03185
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_03185/input1.txt",
            "BOJ/BOJ_03185/input2.txt",
            "BOJ/BOJ_03185/input3.txt",
        ];

        public static void Run(string[] args)
        {
            HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };

            string answer = Console.ReadLine()!;

            int letterCnt = 0;
            int lastVowelIdx = -1;
            System.Text.StringBuilder hint1 = new();

            for (int i = 0; i < answer.Length; i++)
            {
                char c = answer[i];

                if (char.IsLetter(c))
                {
                    letterCnt++;
                    if (vowels.Contains(char.ToLower(c)))
                        lastVowelIdx = i;
                    hint1.Append('.');
                }
                else
                    hint1.Append(c);
            }

            int hint2Cnt = (int)Math.Round(letterCnt / 3.0);
            int hint3Cnt = (int)Math.Round(letterCnt / 3.0 * 2);
            bool vowelRemaining = false;
            System.Text.StringBuilder hint2 = new();
            System.Text.StringBuilder hint3 = new();

            for (int i = 0; i < answer.Length; i++)
            {
                char c = answer[i];

                if (char.IsLetter(c))
                {
                    if (hint2Cnt > 0)
                    {
                        if (--hint2Cnt == 0)
                            vowelRemaining = lastVowelIdx > i;
                        hint3Cnt--;
                        hint2.Append(c);
                        hint3.Append(c);
                    }
                    else
                    {
                        hint2.Append('.');
                        if (vowelRemaining)
                            hint3.Append(vowels.Contains(char.ToLower(c)) ? c : '.');
                        else
                            hint3.Append(hint3Cnt-- > 0 ? c : '.');
                    }
                }
                else
                {
                    hint2.Append(c);
                    hint3.Append(c);
                }
            }

            Console.WriteLine(hint1);
            Console.WriteLine(hint2);
            Console.WriteLine(hint3);
        }
    }
}
