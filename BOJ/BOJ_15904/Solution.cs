namespace Algorithm.BOJ.BOJ_15904
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15904/input1.txt",
            "BOJ/BOJ_15904/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string str = Console.ReadLine()!;
            string abbr = "UCPC";
            int idx = 0;
            string answer = "I hate UCPC";
            foreach (char c in str)
            {
                if (c == abbr[idx])
                {
                    if (++idx == abbr.Length)
                    {
                        answer = "I love UCPC";
                        break;
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
