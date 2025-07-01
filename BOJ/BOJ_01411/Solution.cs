namespace Algorithm.BOJ.BOJ_01411
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01411/input1.txt",
            "BOJ/BOJ_01411/input2.txt",
            "BOJ/BOJ_01411/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            Dictionary<string, int> wordCounts = new();

            for (int _ = 0; _ < N; _++)
            {
                char[] symbolMap = new char[26];
                char symbol = 'a';

                string A = Console.ReadLine()!;
                string B = "";

                foreach (char c in A)
                {
                    int idx = c - 'a';

                    if (symbolMap[idx] == 0)
                        symbolMap[idx] = symbol++;

                    B += symbolMap[idx];
                }

                if (!wordCounts.TryAdd(B, 1))
                    wordCounts[B]++;
            }

            int totalCnt = 0;

            foreach (int cnt in wordCounts.Values)
                totalCnt += cnt * (cnt - 1) / 2;

            Console.WriteLine(totalCnt);
        }
    }
}
