namespace Algorithm.BOJ.BOJ_01992
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01992/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            char[,] video = new char[N, N];
            for (int i = 0; i < N; i++)
            {
                string row = Console.ReadLine()!;
                for (int j = 0; j < N; j++) video[i, j] = row[j];
            }

            Console.WriteLine(QuadTree(video, 0, 0, N));
        }

        private static string QuadTree(char[,] video, int r, int c, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (video[r + i, c + j] != video[r, c])
                    {
                        int h = n / 2;
                        return "("
                            + QuadTree(video, r, c, h)
                            + QuadTree(video, r, c + h, h)
                            + QuadTree(video, r + h, c, h)
                            + QuadTree(video, r + h, c + h, h)
                            + ")";
                    }

            return video[r, c].ToString();
        }
    }
}
