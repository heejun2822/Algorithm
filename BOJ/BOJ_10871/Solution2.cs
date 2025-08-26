namespace Algorithm.BOJ.BOJ_10871
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10871/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nx = Console.ReadLine()!.Split();
            int N = int.Parse(nx[0]);
            int X = int.Parse(nx[1]);
            int[] A = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            System.Text.StringBuilder answer = new();
            for (int i = 0; i < N; i++)
            {
                if (A[i] < X) answer.Append($"{A[i]} ");
            }
            Console.WriteLine(answer);
        }
    }
}
