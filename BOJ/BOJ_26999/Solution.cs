namespace Algorithm.BOJ.BOJ_26999
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
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
                    int size = 0;
                    if (FindPasture(r, c, ref size))
                        maxSize = Math.Max(maxSize, size);
                }
            }

            sw.WriteLine(maxSize);

            sr.Close();
            sw.Close();

            bool FindPasture(int r, int c, ref int size)
            {
                if (visited[r, c] || satellitePhoto[r][c] == '.') return false;

                visited[r, c] = true;
                size++;

                if (r - 1 >= 0) FindPasture(r - 1, c, ref size);
                if (r + 1 < H) FindPasture(r + 1, c, ref size);
                if (c - 1 >= 0) FindPasture(r, c - 1, ref size);
                if (c + 1 < W) FindPasture(r, c + 1, ref size);

                return true;
            }
        }
    }
}
