namespace Algorithm.BOJ.BOJ_16408
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_16408/input1.txt",
            "BOJ/BOJ_16408/input2.txt",
            "BOJ/BOJ_16408/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] cards = Console.ReadLine()!.Split();
            int[] counts = new int[13];
            foreach (string card in cards)
            {
                int rank = card[0] switch
                {
                    'A' => 0,
                    'T' => 9,
                    'J' => 10,
                    'Q' => 11,
                    'K' => 12,
                    _ => card[0] - '1',
                };
                counts[rank]++;
            }
            Console.WriteLine(counts.Max());
        }
    }
}
