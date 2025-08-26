namespace Algorithm.BOJ.BOJ_13136
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13136/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] rcn = Console.ReadLine()!.Split();
            int R = int.Parse(rcn[0]);
            int C = int.Parse(rcn[1]);
            int N = int.Parse(rcn[2]);

            Console.WriteLine((long)((R + N - 1) / N) * ((C + N - 1) / N));
        }
    }
}
