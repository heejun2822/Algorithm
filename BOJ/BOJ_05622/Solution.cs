namespace Algorithm.BOJ.BOJ_05622
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_05622/input1.txt",
            "BOJ/BOJ_05622/input2.txt",
        ];

        public static void Run(string[] args)
        {
            Dictionary<char, int> times = new() {
                {'A', 3}, {'B', 3}, {'C', 3},
                {'D', 4}, {'E', 4}, {'F', 4},
                {'G', 5}, {'H', 5}, {'I', 5},
                {'J', 6}, {'K', 6}, {'L', 6},
                {'M', 7}, {'N', 7}, {'O', 7},
                {'P', 8}, {'Q', 8}, {'R', 8}, {'S', 8},
                {'T', 9}, {'U', 9}, {'V', 9},
                {'W', 10}, {'X', 10}, {'Y', 10}, {'Z', 10},
            };
            string word = Console.ReadLine()!;
            int answer = 0;
            foreach (char c in word) answer += times[c];
            Console.WriteLine(answer);
        }
    }
}
