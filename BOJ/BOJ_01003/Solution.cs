namespace Algorithm.BOJ.BOJ_01003
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01003/input1.txt",
            "BOJ/BOJ_01003/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            List<(int zero, int one)> counts = new(41) { (1, 0), (0, 1) };

            for (int _ = 0; _ < T; _++)
            {
                int N = int.Parse(Console.ReadLine()!);

                while (counts.Count <= N)
                    counts.Add((counts[^1].zero + counts[^2].zero, counts[^1].one + counts[^2].one));

                Console.WriteLine($"{counts[N].zero} {counts[N].one}");
            }
        }
    }
}
