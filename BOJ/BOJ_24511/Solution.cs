namespace Algorithm.BOJ.BOJ_24511
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_24511/input1.txt",
            "BOJ/BOJ_24511/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int[] B = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int M = int.Parse(Console.ReadLine()!);
            int[] C = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            StringBuilder answer = new();
            int cnt = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                if (A[i] == 1) continue;
                answer.Append($"{B[i]} ");
                if (++cnt == M) break;
            }
            for (int i = 0; i < M - cnt; i++)
            {
                answer.Append($"{C[i]} ");
            }

            Console.WriteLine(answer);
        }
    }
}
