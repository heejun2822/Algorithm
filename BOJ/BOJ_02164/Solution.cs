namespace Algorithm.BOJ.BOJ_02164
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02164/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            Console.WriteLine(FilterCard(N, true));
        }

        private static int FilterCard(int size, bool isEvenFilter)
        {
            if (size == 1) return 1;

            int filteredSize = size % 2 == 1 && !isEvenFilter ? size / 2 + 1 : size / 2;
            bool isEvenFilterNext = size % 2 == 0 ? isEvenFilter : !isEvenFilter;

            if (isEvenFilter) return 2 * FilterCard(filteredSize, isEvenFilterNext);
            else return 2 * FilterCard(filteredSize, isEvenFilterNext) - 1;
        }
    }
}
