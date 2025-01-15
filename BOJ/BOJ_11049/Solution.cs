namespace Algorithm.BOJ.BOJ_11049
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11049/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            (int r, int c)[] matrices = new (int, int)[N];
            for (int i = 0; i < N; i++)
            {
                string[] dimension = Console.ReadLine()!.Split();
                matrices[i] = (int.Parse(dimension[0]), int.Parse(dimension[1]));
            }

            int[,] minCalCnt = new int[N, N];
            for (int o = 1; o < N; o++)
                for (int s = 0; s + o < N; s++)
                {
                    minCalCnt[s, s + o] = int.MaxValue;
                    for (int i = 0; i < o; i++)
                        minCalCnt[s, s + o] = Math.Min(
                            minCalCnt[s, s + o],
                            minCalCnt[s, s + i] + minCalCnt[s + i + 1, s + o]
                            + matrices[s].r * matrices[s + i].c * matrices[s + o].c
                        );
                }

            Console.WriteLine(minCalCnt[0, N - 1]);
        }
    }
}
