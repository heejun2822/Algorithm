namespace Algorithm.BOJ.BOJ_26505
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_26505/input.txt",
        ];

        public static void Run(string[] args)
        {
            int[] Fortunate = { 0, 3, 5, 7, 13, 23, 17, 19, 23, 37, 61, 67, 61, 71, 47 };
            int[] Less = { 0, 0, 3, 7, 11, 13, 17, 29, 23, 43, 41, 73, 59, 47, 89 };

            int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            foreach (int N in numbers)
                Console.WriteLine($"N = {N} FORTUNATE = {Fortunate[N]} LESS = {Less[N]}");
        }
    }
}
