namespace Algorithm.BOJ.BOJ_11504
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11504/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            for (int _ = 0; _ < T; _++)
            {
                string[] nm = Console.ReadLine()!.Split();
                int N = int.Parse(nm[0]);
                int M = int.Parse(nm[1]);
                int X = int.Parse(Console.ReadLine()!.Replace(" ", ""));
                int Y = int.Parse(Console.ReadLine()!.Replace(" ", ""));
                int[] wheel = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
                int cnt = 0;
                for (int i = 0; i < N; i++)
                {
                    int Z = 0;
                    for (int j = 0; j < M; j++) Z = 10 * Z + wheel[(i + j) % N];
                    if (Z >= X && Z <= Y) cnt++;
                }
                Console.WriteLine(cnt);
            }
        }
    }
}
