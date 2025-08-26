namespace Algorithm.BOJ.BOJ_10810
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10810/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            int[] baskets = new int[N];
            for (int i = 0; i < M; i++)
            {
                int[] info = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
                for (int j = info[0] - 1; j <= info[1] - 1; j++)
                {
                    baskets[j] = info[2];
                }
            }
            Console.WriteLine(string.Join(" ", baskets));
        }
    }
}
