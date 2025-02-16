namespace Algorithm.BOJ.BOJ_27162
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_27162/input1.txt",
            "BOJ/BOJ_27162/input2.txt",
            "BOJ/BOJ_27162/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string hands = Console.ReadLine()!;
            int[] diceCount = new int[7];

            string[] dice = Console.ReadLine()!.Split();
            for (int i = 0; i < 3; i++) diceCount[int.Parse(dice[i])]++;

            int maxScore = 0;

            if (hands[0] == 'Y') maxScore = Math.Max(maxScore, Ones(diceCount));
            if (hands[1] == 'Y') maxScore = Math.Max(maxScore, Twos(diceCount));
            if (hands[2] == 'Y') maxScore = Math.Max(maxScore, Threes(diceCount));
            if (hands[3] == 'Y') maxScore = Math.Max(maxScore, Fours(diceCount));
            if (hands[4] == 'Y') maxScore = Math.Max(maxScore, Fives(diceCount));
            if (hands[5] == 'Y') maxScore = Math.Max(maxScore, Sixes(diceCount));
            if (hands[6] == 'Y') maxScore = Math.Max(maxScore, FourOfAKind(diceCount));
            if (hands[7] == 'Y') maxScore = Math.Max(maxScore, FullHouse(diceCount));
            if (hands[8] == 'Y') maxScore = Math.Max(maxScore, LittleStraight(diceCount));
            if (hands[9] == 'Y') maxScore = Math.Max(maxScore, BigStraight(diceCount));
            if (hands[10] == 'Y') maxScore = Math.Max(maxScore, Yacht(diceCount));
            if (hands[11] == 'Y') maxScore = Math.Max(maxScore, Choice(diceCount));

            Console.WriteLine(maxScore);
        }

        private static int Ones(int[] diceCount)
        {
            return (diceCount[1] + 2) * 1;
        }

        private static int Twos(int[] diceCount)
        {
            return (diceCount[2] + 2) * 2;
        }

        private static int Threes(int[] diceCount)
        {
            return (diceCount[3] + 2) * 3;
        }

        private static int Fours(int[] diceCount)
        {
            return (diceCount[4] + 2) * 4;
        }

        private static int Fives(int[] diceCount)
        {
            return (diceCount[5] + 2) * 5;
        }

        private static int Sixes(int[] diceCount)
        {
            return (diceCount[6] + 2) * 6;
        }

        private static int FourOfAKind(int[] diceCount)
        {
            for (int i = 1; i <= 6; i++)
                if (diceCount[i] >= 2)
                    return 4 * i;
            return 0;
        }

        private static int FullHouse(int[] diceCount)
        {
            int cnt1 = 0, cnt2 = 0, cnt3 = 0;
            for (int i = 1; i <= 6; i++)
            {
                if (diceCount[i] == 1) cnt1 = i;
                else if (diceCount[i] == 2) cnt2 = i;
                else if (diceCount[i] == 3) cnt3 = i;
            }

            if (cnt3 != 0)
                for (int i = 6; i > 0; i--)
                    if (i != cnt3)
                        return 3 * cnt3 + 2 * i;
            if (cnt2 != 0)
                return 3 * Math.Max(cnt1, cnt2) + 2 * Math.Min(cnt1, cnt2);
            return 0;
        }

        private static int LittleStraight(int[] diceCount)
        {
            int cnt = 0;
            for (int i = 1; i <= 5; i++)
                if (diceCount[i] == 1) cnt++;

            return cnt == 3 ? 30 : 0;
        }

        private static int BigStraight(int[] diceCount)
        {
            int cnt = 0;
            for (int i = 2; i <= 6; i++)
                if (diceCount[i] == 1) cnt++;

            return cnt == 3 ? 30 : 0;
        }

        private static int Yacht(int[] diceCount)
        {
            for (int i = 1; i <= 6; i++)
                if (diceCount[i] == 3)
                    return 50;
            return 0;
        }

        private static int Choice(int[] diceCount)
        {
            int score = 12;
            for (int i = 1; i <= 6; i++)
                score += diceCount[i] * i;

            return score;
        }
    }
}
