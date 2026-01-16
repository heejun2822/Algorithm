namespace Algorithm.BOJ.BOJ_07008
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_07008/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            while (T-- > 0)
            {
                int n = int.Parse(Console.ReadLine()!);

                char[] ciphertext = new char[n];

                int idx = 0;
                while (idx < n)
                    foreach (char c in Console.ReadLine()!)
                        if (c >= 'A' && c <= 'Z')
                            ciphertext[idx++] = c;

                string crib = Console.ReadLine()!;

                (int s, int m) = FindEncryptionKey(n, ciphertext, crib);

                if (s == -1 && m == -1)
                    Console.WriteLine("Crib is not encrypted.");
                else
                    Console.WriteLine($"{s} {m}");
            }

            (int s, int m) FindEncryptionKey(int n, char[] ciphertext, string crib)
            {
                for (int s = 1; s <= 25; s++)
                {
                    List<int> list = new();

                    for (int i = 0; i < n; i++)
                        if ((ciphertext[i] = (char)('A' + (ciphertext[i] - 'A' + 25) % 26)) == crib[0])
                            list.Add(i);

                    if (list.Count == 0) continue;

                    for (int m = 5; m <= 20; m++)
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            bool found = true;
                            int idx = list[i];

                            foreach (char c in crib)
                            {
                                if (idx == -1 || ciphertext[idx] != c)
                                {
                                    found = false;
                                    break;
                                }

                                if (idx % m > 0)
                                    idx--;
                                else if (idx + m < ciphertext.Length)
                                    idx = Math.Min(idx + 2 * m - 1, ciphertext.Length - 1);
                                else
                                    idx = -1;
                            }

                            if (found)
                                return (s, m);
                        }
                    }
                }

                return (-1, -1);
            }
        }
    }
}
