namespace Algorithm.BOJ.BOJ_09372
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09372/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                string[] nm = sr.ReadLine()!.Split();
                int N = int.Parse(nm[0]);
                int M = int.Parse(nm[1]);

                for (int i = 0; i < M; i++) sr.ReadLine();

                sw.WriteLine(N - 1);
            }

            sr.Close();
            sw.Close();
        }
    }
}
