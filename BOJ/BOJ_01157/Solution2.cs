namespace Algorithm.BOJ.BOJ_01157
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01157/input1.txt",
            "BOJ/BOJ_01157/input2.txt",
            "BOJ/BOJ_01157/input3.txt",
            "BOJ/BOJ_01157/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string word = Console.ReadLine()!.ToUpper();
            int[] counts = new int[26];
            foreach (char c in word) counts[c - 'A']++;
            char answer = '?';
            int max = 0;
            for (int i = 0; i < 26; i++)
            {
                if (counts[i] < max) continue;
                answer = counts[i] > max ? (char)(i + 'A') : '?';
                max = counts[i];
            }
            Console.WriteLine(answer);
        }
    }
}
