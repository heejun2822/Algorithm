namespace Algorithm.BOJ.BOJ_11659
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11659/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            string[] nm = sr.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            int[] numbers = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            int[] acc = new int[N + 1];
            for (int i = 1; i <= N; i++) acc[i] = acc[i - 1] + numbers[i - 1];

            for (int _ = 0; _ < M; _++)
            {
                string[] input = sr.ReadLine()!.Split();
                int i = int.Parse(input[0]);
                int j = int.Parse(input[1]);
                sw.WriteLine(acc[j] - acc[i - 1]);
            }

            sr.Close();
            sw.Close();
        }
    }
}
