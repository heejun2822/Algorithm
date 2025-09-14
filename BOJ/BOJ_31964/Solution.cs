namespace Algorithm.BOJ.BOJ_31964
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31964/input1.txt",
            "BOJ/BOJ_31964/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] X = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int[] T = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int time = Math.Max(X[N - 1], T[N - 1]);

            for (int i = N - 2; i >= 0; i--)
                time = Math.Max(time + X[i + 1] - X[i], T[i]);

            time += X[0];

            Console.WriteLine(time);
        }
    }
}
