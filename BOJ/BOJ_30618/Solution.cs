namespace Algorithm.BOJ.BOJ_30618
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30618/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder P = new();

            if (N % 2 == 0)
            {
                for (int i = 1; i <= N - 1; i += 2) P.Append(i).Append(' ');
                for (int i = N; i >= 2; i -= 2) P.Append(i).Append(' ');
            }
            else
            {
                for (int i = 1; i <= N; i += 2) P.Append(i).Append(' ');
                for (int i = N - 1; i >= 2; i -= 2) P.Append(i).Append(' ');
            }

            Console.WriteLine(P);
        }
    }
}
