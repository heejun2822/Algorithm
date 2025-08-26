namespace Algorithm.BOJ.BOJ_14425
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14425/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            HashSet<string> S = new(N);
            for (int _ = 0; _ < N; _++) S.Add(Console.ReadLine()!);
            int cnt = 0;
            for (int _ = 0; _ < M; _++)
            {
                if (S.Contains(Console.ReadLine()!)) cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
