namespace Algorithm.BOJ.BOJ_31134
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31134/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            System.Text.StringBuilder answer = new();

            for (int _ = 0; _ < T; _++)
            {
                int x = int.Parse(sr.ReadLine()!);
                long n = 2L * x - 1;
                answer.AppendLine(n.ToString());
            }

            sw.Write(answer);

            sr.Close();
            sw.Close();
        }
    }
}
