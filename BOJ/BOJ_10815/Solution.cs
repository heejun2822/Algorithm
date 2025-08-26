namespace Algorithm.BOJ.BOJ_10815
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10815/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            HashSet<int> cards = Console.ReadLine()!.Split().Select(int.Parse).ToHashSet();
            int M = int.Parse(Console.ReadLine()!);
            int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            for (int i = 0; i < M; i++)
            {
                numbers[i] = cards.Contains(numbers[i]) ? 1 : 0;
            }
            Console.WriteLine(string.Join(' ', numbers));
        }
    }
}
