namespace Algorithm.BOJ.BOJ_07587
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_07587/input.txt",
        ];

        public static void Run(string[] args)
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine()!);

                if (n == 0) break;

                List<(string word, int cnt)> list = new();

                for (int _ = 0; _ < n; _++)
                {
                    string word = Console.ReadLine()!;
                    bool isAnagram = false;

                    int[] counts1 = new int[26];
                    foreach (char c in word) counts1[c - 'a']++;

                    for (int i = 0; i < list.Count; i++)
                    {
                        isAnagram = true;

                        int[] counts2 = new int[26];
                        foreach (char c in list[i].word) counts2[c - 'a']++;

                        for (int j = 0; j < 26; j++)
                        {
                            if (counts1[j] != counts2[j])
                            {
                                isAnagram = false;
                                break;
                            }
                        }

                        if (isAnagram)
                        {
                            list[i] = (list[i].word, list[i].cnt + 1);
                            break;
                        }
                    }

                    if (!isAnagram) list.Add((word, 0));
                }

                list.Sort((a, b) => b.cnt - a.cnt);

                Console.WriteLine($"{list[0].word} {list[0].cnt}");
            }
        }
    }
}
