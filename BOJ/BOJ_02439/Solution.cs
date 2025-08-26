namespace Algorithm.BOJ.BOJ_02439
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02439/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            System.Text.StringBuilder stars = new();
            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < N - i; j++) stars.Append(' ');
                for (int j = 0; j < i; j++) stars.Append('*');
                stars.Append('\n');
            }
            Console.WriteLine(stars);
        }
    }
}
