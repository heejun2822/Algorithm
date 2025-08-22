namespace Algorithm.PRO.PRO_258707 // n + 1 카드게임
{
    class Solution
    {
        private static Solution Instance { get; } = new();

        public static string[] InputPaths { get; private set; } =
        [
            "PRO/PRO_258707/input1.txt",
            "PRO/PRO_258707/input2.txt",
            "PRO/PRO_258707/input3.txt",
            "PRO/PRO_258707/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int coin = System.Text.Json.JsonSerializer.Deserialize<int>(Console.ReadLine()!);
            int[] cards = System.Text.Json.JsonSerializer.Deserialize<int[]>(Console.ReadLine()!)!;

            Console.WriteLine(Instance.solution(coin, cards));
        }

        public int solution(int coin, int[] cards)
        {
            int n = cards.Length;
            bool[] isDrawn = new bool[n + 1];
            bool[] isCoinDrawn = new bool[n + 1];
            int[] pairCnt = new int[3];
            int idx = 0;

            while (idx < n / 3)
            {
                int card = cards[idx++];
                isDrawn[card] = true;
                if (isDrawn[n + 1 - card])
                    pairCnt[0]++;
            }

            int round = 1;

            while (idx < n)
            {
                for (int _ = 0; _ < 2; _++)
                {
                    int card = cards[idx++];
                    isDrawn[card] = true;
                    isCoinDrawn[card] = true;
                    if (isDrawn[n + 1 - card])
                        pairCnt[isCoinDrawn[n + 1 - card] ? 2 : 1]++;
                }

                bool nextRound = false;

                for (int c = 0; c < 3; c++)
                {
                    if (pairCnt[c] > 0 && coin >= c)
                    {
                        pairCnt[c]--;
                        coin -= c;
                        nextRound = true;
                        break;
                    }
                }

                if (!nextRound) break;

                round++;
            }

            return round;
        }
    }
}
