namespace Algorithm.BOJ.BOJ_05587
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_05587/input1.txt",
            "BOJ/BOJ_05587/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            int[] cards = new int[2 * n + 1];

            for (int _ = 0; _ < n; _++)
                cards[int.Parse(Console.ReadLine()!)] = 1;

            int[] cardCnt = { n, n };
            int l = 1, h = 2 * n;
            int currentTurn = 1;

            while (true)
            {
                int turnCnt = 0;

                for (int i = l; i <= h; i++)
                {
                    if (cards[i] == -1) continue;

                    if (cards[i] == currentTurn)
                    {
                        cards[i] = -1;
                        if (--cardCnt[currentTurn] == 0) goto Finish;
                        currentTurn = currentTurn == 0 ? 1 : 0;
                        turnCnt++;
                    }
                }

                currentTurn = currentTurn == 0 ? 1 : 0;

                if (turnCnt == 1)
                {
                    cardCnt[currentTurn] = 0;
                    goto Finish;
                }

                while (cards[l] == -1) l++;
                while (cards[h] == -1) h--;
            }

            Finish:
            Console.WriteLine(cardCnt[0]);
            Console.WriteLine(cardCnt[1]);
        }
    }
}
