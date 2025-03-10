namespace Algorithm.BOJ.BOJ_04446
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_04446/input.txt",
        ];

        public static void Run(string[] args)
        {
            string vowels = "aiyeou";
            string consonants = "bkxznhdcwgpvjqtsrlmf";

            string ROT13;
            System.Text.StringBuilder original = new();

            while ((ROT13 = Console.ReadLine()!) != null)
            {
                foreach (char c in ROT13)
                {
                    if (char.IsLower(c))
                    {
                        int idx = vowels.IndexOf(c);
                        if (idx != -1)
                            original.Append(vowels[(idx + 3) % vowels.Length]);
                        else
                        {
                            idx = consonants.IndexOf(c);
                            original.Append(consonants[(idx + 10) % consonants.Length]);
                        }
                    }
                    else if (char.IsUpper(c))
                    {
                        int idx = vowels.IndexOf(char.ToLower(c));
                        if (idx != -1)
                            original.Append(char.ToUpper(vowels[(idx + 3) % vowels.Length]));
                        else
                        {
                            idx = consonants.IndexOf(char.ToLower(c));
                            original.Append(char.ToUpper(consonants[(idx + 10) % consonants.Length]));
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
