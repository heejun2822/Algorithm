namespace Algorithm.BOJ.BOJ_04446
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04446/input.txt",
        ];

        public static void Run(string[] args)
        {
            char[] vowels = { 'a', 'i', 'y', 'e', 'o', 'u' };
            char[] consonants = { 'b', 'k', 'x', 'z', 'n', 'h', 'd', 'c', 'w', 'g', 'p', 'v', 'j', 'q', 't', 's', 'r', 'l', 'm', 'f' };

            string ROT13;
            System.Text.StringBuilder original = new();

            while ((ROT13 = Console.ReadLine()!) != null)
            {
                foreach (char c in ROT13)
                {
                    if (c >= 'a' && c <= 'z')
                    {
                        int idx = Array.IndexOf(vowels, c);
                        if (idx != -1)
                            original.Append(vowels[(idx + 3) % vowels.Length]);
                        else
                        {
                            idx = Array.IndexOf(consonants, c);
                            original.Append(consonants[(idx + 10) % consonants.Length]);
                        }
                    }
                    else if (c >= 'A' && c <= 'Z')
                    {
                        int idx = Array.IndexOf(vowels, (char)(c - 'A' + 'a'));
                        if (idx != -1)
                            original.Append((char)(vowels[(idx + 3) % vowels.Length] - 'a' + 'A'));
                        else
                        {
                            idx = Array.IndexOf(consonants, (char)(c - 'A' + 'a'));
                            original.Append((char)(consonants[(idx + 10) % consonants.Length] - 'a' + 'A'));
                        }
                    }
                    else
                    {
                        original.Append(c);
                    }
                }
                original.Append('\n');
            }

            Console.WriteLine(original);
        }
    }
}
