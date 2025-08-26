namespace Algorithm.BOJ.BOJ_05171
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05171/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int n = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);

            bool[,,] database = new bool[n, 5, 5];
            for (int i = 0; i < n; i++)
            {
                for (int r = 0; r < 5; r++)
                {
                    string row = Console.ReadLine()!;
                    for (int c = 0; c < 5; c++)
                    {
                        database[i, r, c] = row[c] == '.';
                    }
                }
            }

            for (int t = 1; t <= K; t++)
            {
                bool[,] crimeFingerprint = new bool[5, 5];
                for (int r = 0; r < 5; r++)
                {
                    string row = Console.ReadLine()!;
                    for (int c = 0; c < 5; c++)
                    {
                        crimeFingerprint[r, c] = row[c] == '.';
                    }
                }

                int bestMatch = 0;
                Queue<int> indices = new();
                for (int i = 0; i < n; i++)
                {
                    int cnt = 0;
                    for (int r = 0; r < 5; r++)
                        for (int c = 0; c < 5; c++)
                            if (database[i, r, c] == crimeFingerprint[r, c]) cnt++;

                    if (cnt > bestMatch)
                    {
                        bestMatch = cnt;
                        indices.Clear();
                        indices.Enqueue(i + 1);
                    }
                    else if (cnt == bestMatch)
                        indices.Enqueue(i + 1);
                }

                Console.WriteLine($"Data Set {t}:");
                while (indices.Count > 0) Console.Write($"{indices.Dequeue()} ");
                Console.Write("\n\n");
            }
        }
    }
}
