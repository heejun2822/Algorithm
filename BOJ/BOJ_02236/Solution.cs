namespace Algorithm.BOJ.BOJ_02236
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02236/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            int[] importances = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            (int imp, int idx)[] sorted = new (int, int)[N];

            for (int i = 0; i < N; i++)
                sorted[i] = (importances[i], i);

            Array.Sort(sorted, (a, b) => b.imp - a.imp);

            bool[] isPowered = new bool[N];

            for (int i = 0; i < K; i++)
            {
                if (i < N)
                {
                    isPowered[sorted[i].idx] = true;
                    Console.WriteLine(sorted[i].idx + 1);
                }
                else
                {
                    Console.WriteLine(0);
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(isPowered[i] ? i + 1 : 0);
            }
        }
    }
}
