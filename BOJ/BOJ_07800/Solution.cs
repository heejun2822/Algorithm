namespace Algorithm.BOJ.BOJ_07800
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_07800/input.txt",
        ];

        public static void Run(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine()!;

                if (input == null) break;

                string[] splitted = input.Split();
                int N = int.Parse(splitted[0]), M = int.Parse(splitted[1]);

                int[,] matrix = new int[N, N];

                for (int i = 0; i < N; i++)
                {
                    string[] line = Console.ReadLine()!.Split();
                    for (int j = 0; j < N; j++)
                        matrix[i, j] = int.Parse(line[j]);
                }

                List<int> chosen = new();
                int row = 0, col = 0;

                for (int r = 0; r <= N - M; r++)
                {
                    for (int c = 0; c <= N - M; c++)
                    {
                        HashSet<int> set = new();

                        for (int i = 0; i < M; i++)
                            for (int j = 0; j < M; j++)
                                set.Add(matrix[r + i, c + j]);

                        List<int> list = set.ToList();
                        list.Sort((a, b) => b - a);

                        if ((row == 0 && col == 0) || list.Count < chosen.Count)
                        {
                            chosen = list;
                            row = r + 1;
                            col = c + 1;
                        }
                        else if (list.Count == chosen.Count)
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i] > chosen[i])
                                {
                                    chosen = list;
                                    row = r + 1;
                                    col = c + 1;
                                    break;
                                }
                                else if (list[i] < chosen[i])
                                {
                                    break;
                                }
                            }
                        }
                    }
                }

                Console.WriteLine($"{row} {col}");
            }
        }
    }
}
