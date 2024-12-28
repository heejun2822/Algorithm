namespace Algorithm.BOJ.BOJ_24912
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_24912/input1.txt",
            "BOJ/BOJ_24912/input2.txt",
            "BOJ/BOJ_24912/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Console.WriteLine(ColorCards(a, 0) == 1 ? string.Join(' ', a) : "-1");
        }

        private static int ColorCards(int[] cards, int idx)
        {
            if (idx == cards.Length) return 1;

            if (cards[idx] != 0)
            {
                if (!IsValidColor(cards, idx)) return -1;
                return ColorCards(cards, idx + 1);
            }

            for (int c = 1; c <= 3; c++)
            {
                cards[idx] = c;
                if (!IsValidColor(cards, idx)) continue;
                int result = ColorCards(cards, idx + 1);
                if (result != 0) return result;
            }
            cards[idx] = 0;
            return 0;
        }

        private static bool IsValidColor(int[] cards, int idx)
        {
            if (idx > 0 && cards[idx - 1] == cards[idx]) return false;
            if (idx < cards.Length - 1 && cards[idx + 1] == cards[idx]) return false;
            return true;
        }
    }
}
