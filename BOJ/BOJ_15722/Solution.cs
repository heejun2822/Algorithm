namespace Algorithm.BOJ.BOJ_15722
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15722/input1.txt",
            "BOJ/BOJ_15722/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int[] dx = { 0, 1, 0, -1 };
            int[] dy = { 1, 0, -1, 0 };

            int n = int.Parse(Console.ReadLine()!);

            int x = 0, y = 0;
            int itr = 0;

            while (n > 0)
            {
                int len = Math.Min(1 + itr / 2, n);

                x += dx[itr % 4] * len;
                y += dy[itr % 4] * len;

                n -= len;
                itr++;
            }

            Console.WriteLine($"{x} {y}");
        }
    }
}
