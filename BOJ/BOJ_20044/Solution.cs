namespace Algorithm.BOJ.BOJ_20044
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20044/input1.txt",
            "BOJ/BOJ_20044/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] w = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Array.Sort(w);

            int Sm = 200_000;

            for (int s = 0; s < n; s++)
                Sm = Math.Min(Sm, w[s] + w[^(s + 1)]);

            Console.WriteLine(Sm);
        }
    }
}
