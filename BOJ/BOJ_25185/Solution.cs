namespace Algorithm.BOJ.BOJ_25185
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25185/input.txt",
        ];

        public static void Run(string[] args)
        {
            Dictionary<char, int> map = new() { { 'm', 0 }, { 'p', 1 }, { 's', 2 } };

            int T = int.Parse(Console.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                string[] input = Console.ReadLine()!.Split();

                int[,] cards = new int[3, 9];

                for (int i = 0; i < 4; i++)
                    cards[map[input[i][1]], input[i][0] - '1']++;

                Console.WriteLine(CheckRestingRules(cards) ? ":)" : ":(");
            }

            bool CheckRestingRules(int[,] cards)
            {
                int repeated = 0;

                for (int i = 0; i < 3; i++)
                {
                    int continued = 0;

                    for (int j = 0; j < 9; j++)
                    {
                        if (cards[i, j] >= 1 && ++continued == 3) return true;
                        if (cards[i, j] >= 3) return true;
                        if (cards[i, j] == 2 && ++repeated == 2) return true;
                        if (cards[i, j] == 0) continued = 0;
                    }
                }

                return false;
            }
        }
    }
}
