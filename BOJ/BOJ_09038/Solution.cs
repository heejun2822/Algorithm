namespace Algorithm.BOJ.BOJ_09038
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09038/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            while (T-- > 0)
            {
                int w = int.Parse(Console.ReadLine()!);
                string[] words = Console.ReadLine()!.Split();

                int lineCnt = 1;
                int remainingSpace = w;

                foreach (string word in words)
                {
                    if (remainingSpace < word.Length)
                    {
                        lineCnt++;
                        remainingSpace = w;
                    }
                    remainingSpace -= word.Length + 1;
                }

                Console.WriteLine(lineCnt);
            }
        }
    }
}
