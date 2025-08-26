namespace Algorithm.BOJ.BOJ_12109
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12109/input1.txt",
            "BOJ/BOJ_12109/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] C = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            Array.Sort(C, (a, b) => b - a);

            int H = -1;
            while (++H < N) if (C[H] < H + 1) break;

            Console.WriteLine(H);
        }
    }
}
