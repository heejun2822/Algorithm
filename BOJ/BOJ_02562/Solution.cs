namespace Algorithm.BOJ.BOJ_02562
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02562/input.txt",
        ];

        public static void Run(string[] args)
        {
            List<int> numbers = new();
            for (int i = 0; i < 9; i++) numbers.Add(int.Parse(Console.ReadLine()!));
            int max = numbers.Max();
            int index = numbers.IndexOf(max);
            Console.WriteLine(max);
            Console.WriteLine(index + 1);
        }
    }
}
