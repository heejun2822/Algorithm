namespace Algorithm.BOJ.BOJ_20492
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20492/input1.txt",
            "BOJ/BOJ_20492/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int prize1 = N / 100 * 78;
            int prize2 = N / 100 * 80 + N / 100 * 20 / 100 * 78;
            Console.WriteLine($"{prize1} {prize2}");
        }
    }
}
