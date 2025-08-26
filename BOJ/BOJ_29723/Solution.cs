namespace Algorithm.BOJ.BOJ_29723
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_29723/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]), M = int.Parse(input[1]), K = int.Parse(input[2]);
            Dictionary<string, int> scores = new(N);
            for (int _ = 0; _ < N; _++)
            {
                string[] sp = Console.ReadLine()!.Split();
                scores.Add(sp[0], int.Parse(sp[1]));
            }

            int sum = 0;
            for (int _ = 0; _ < K; _++)
            {
                string s = Console.ReadLine()!;
                sum += scores[s];
                scores.Remove(s);
            }

            int[] points = scores.Values.ToArray();
            Array.Sort(points);

            int min = sum, max = sum;
            for (int i = 0; i < M - K; i++)
            {
                min += points[i];
                max += points[^(i + 1)];
            }

            Console.WriteLine($"{min} {max}");
        }
    }
}
