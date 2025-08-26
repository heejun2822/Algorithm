namespace Algorithm.BOJ.BOJ_01806
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01806/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] ns = Console.ReadLine()!.Split();
            int N = int.Parse(ns[0]);
            int S = int.Parse(ns[1]);
            int[] sequence = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int start = 0, end = 0;
            int sum = 0;
            int minLen = int.MaxValue;

            while (true)
            {
                if (sum >= S)
                {
                    minLen = Math.Min(minLen, end - start);
                    sum -= sequence[start++];
                }
                else
                {
                    if (end == N) break;
                    sum += sequence[end++];
                }
            }

            Console.WriteLine(minLen == int.MaxValue ? "0" : minLen);
        }
    }
}
