namespace Algorithm.BOJ.BOJ_14005
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_14005/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int DuduScore = int.Parse(Console.ReadLine()!);
            int minScore = 1_000_000_000;

            int playerCnt = (int)Math.Pow(2, N) - 1;

            if (playerCnt == 0)
                minScore = 0;
            else
                for (int _ = 0; _ < playerCnt; _++)
                    minScore = Math.Min(minScore, int.Parse(Console.ReadLine()!));

            Console.WriteLine(DuduScore >= minScore ? "YES" : "NO");
        }
    }
}
