namespace Algorithm.BOJ.BOJ_13419
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13419/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                string word = Console.ReadLine()!;

                string first = "", second = "";
                int len = word.Length % 2 == 0 ? word.Length : word.Length * 2;

                for (int i = 0; i < len; i += 2)
                {
                    first += word[i % word.Length];
                    second += word[(i + 1) % word.Length];
                }

                Console.WriteLine(first);
                Console.WriteLine(second);
            }
        }
    }
}
