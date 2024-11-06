namespace Algorithm.BOJ.BOJ_10988
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10988/input1.txt",
            "BOJ/BOJ_10988/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string word = Console.ReadLine()!;
            int answer = 1;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[^(i + 1)])
                {
                    answer = 0;
                    break;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
