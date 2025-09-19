namespace Algorithm.BOJ.BOJ_16234
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16234/input1.txt",
            "BOJ/BOJ_16234/input2.txt",
            "BOJ/BOJ_16234/input3.txt",
            "BOJ/BOJ_16234/input4.txt",
            "BOJ/BOJ_16234/input5.txt",
        ];

        public static void Run(string[] args)
        {
            int[] dr = { 1, -1, 0, 0 };
            int[] dc = { 0, 0, 1, -1 };

            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), L = ReadInt(sr), R = ReadInt(sr);
            int[,] A = new int[N, N];

            for (int r = 0; r < N; r++)
                for (int c = 0; c < N; c++)
                    A[r, c] = ReadInt(sr);

            List<(int r, int c)> countries = new();
            int days = 0;

            while (true)
            {
                bool[,] visited = new bool[N, N];
                bool moved = false;

                for (int r = 0; r < N; r++)
                {
                    for (int c = 0; c < N; c++)
                    {
                        int population = 0;
                        countries.Clear();
                        MakeUnion(r, c, ref population, countries, visited);

                        if (countries.Count == 0 || countries.Count == 1) continue;

                        int newPopulation = population / countries.Count;
                        for (int i = 0; i < countries.Count; i++)
                            A[countries[i].r, countries[i].c] = newPopulation;
                        moved = true;
                    }
                }

                if (moved) days++;
                else break;
            }

            sw.WriteLine(days);

            sr.Close();
            sw.Close();

            void MakeUnion(int r, int c, ref int population, List<(int r, int c)> countries, bool[,] visited)
            {
                if (visited[r, c]) return;

                population += A[r, c];
                countries.Add((r, c));
                visited[r, c] = true;

                for (int i = 0; i < 4; i++)
                {
                    int nr = r + dr[i], nc = c + dc[i];
                    if (nr < 0 || nr >= N || nc < 0 || nc >= N) continue;
                    int diff = Math.Abs(A[r, c] - A[nr, nc]);
                    if (diff < L || diff > R) continue;
                    MakeUnion(nr, nc, ref population, countries, visited);
                }
            }
        }

        private static int ReadInt(StreamReader sr)
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { sr.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
