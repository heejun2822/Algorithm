namespace Algorithm.BOJ.BOJ_17262
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17262/input1.txt",
            "BOJ/BOJ_17262/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            int maxS = 1;
            int minE = 100_000;
            for (int _ = 0; _ < N; _++)
            {
                string[] se = sr.ReadLine()!.Split();
                maxS = Math.Max(maxS, int.Parse(se[0]));
                minE = Math.Min(minE, int.Parse(se[1]));
            }

            sw.WriteLine(Math.Max(maxS - minE, 0));

            sr.Close();
            sw.Close();
        }
    }
}
