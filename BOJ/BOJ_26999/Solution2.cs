namespace Algorithm.BOJ.BOJ_26999
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_26999/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] wh = sr.ReadLine()!.Split();
            int W = int.Parse(wh[0]);
            int H = int.Parse(wh[1]);

            string[] satellitePhoto = new string[H];

            for (int i = 0; i < H; i++)
                satellitePhoto[i] = sr.ReadLine()!;

            bool[,] visited = new bool[H, W];
            int maxSize = 0;

            for (int r = 0; r < H; r++)
            {
                for (int c = 0; c < W; c++)
                {
                    maxSize = Math.Max(maxSize, MeasurePastureSize(r, c));
                }
            }

            sw.WriteLine(maxSize);

            sr.Close();
            sw.Close();

            int MeasurePastureSize(int r, int c)
            {
                if (visited[r, c] || satellitePhoto[r][c] == '.') return 0;

                visited[r, c] = true;
                int size = 1;

                if (r - 1 >= 0) size += MeasurePastureSize(r - 1, c);
                if (r + 1 < H) size += MeasurePastureSize(r + 1, c);
                if (c - 1 >= 0) size += MeasurePastureSize(r, c - 1);
                if (c + 1 < W) size += MeasurePastureSize(r, c + 1);

                return size;
            }
        }
    }
}
