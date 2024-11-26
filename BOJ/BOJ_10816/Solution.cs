namespace Algorithm.BOJ.BOJ_10816
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10816/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] cards = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            Dictionary<int, int> counts = new();
            foreach (int card in cards)
            {
                if (!counts.TryAdd(card, 1)) counts[card]++;
            }
            int M = int.Parse(Console.ReadLine()!);
            int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), n => 
                counts.TryGetValue(int.Parse(n), out int cnt) ? cnt : 0
            );
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
