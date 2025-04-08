namespace Algorithm.BOJ.BOJ_28298
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_28298/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nmk = sr.ReadLine()!.Split();
            int N = int.Parse(nmk[0]);
            int M = int.Parse(nmk[1]);
            int K = int.Parse(nmk[2]);

            string[] tile = new string[N];
            for (int i = 0; i < N; i++) tile[i] = sr.ReadLine()!;

            int[,,] counts = new int[K, K, 26];

            for (int r = 0; r < N; r += K)
                for (int c = 0; c < M; c += K)
                    for (int i = 0; i < K; i++)
                        for (int j = 0; j < K; j++)
                            counts[i, j, tile[r + i][c + j] - 'A']++;

            int repaintCnt = 0;
            char[,] subTile = new char[K, K];
            int subTileCnt = (N / K) * (M / K);

            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    int maxCnt = 0;
                    for (int l = 0; l < 26; l++)
                    {
                        if (counts[i, j, l] > maxCnt)
                        {
                            maxCnt = counts[i, j, l];
                            subTile[i, j] = (char)('A' + l);
                        }
                    }
                    repaintCnt += subTileCnt - maxCnt;
                }
            }

            System.Text.StringBuilder repaintedTile = new();
            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < M; c++)
                    repaintedTile.Append(subTile[r % K, c % K]);
                repaintedTile.Append('\n');
            }

            sw.WriteLine(repaintCnt);
            sw.Write(repaintedTile);

            sr.Close();
            sw.Close();
        }
    }
}
