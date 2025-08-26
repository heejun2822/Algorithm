namespace Algorithm.BOJ.BOJ_05966
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05966/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < N; _++)
            {
                string[] kp = sr.ReadLine()!.Split();
                int K = int.Parse(kp[0]);
                string P = kp[1];

                int stack = 0;

                for (int i = 0; i < K; i++)
                {
                    if (P[i] == '>') stack++;
                    else if (--stack < 0) break;
                }

                sw.WriteLine(stack == 0 ? "legal" : "illegal");
            }

            sr.Close();
            sw.Close();
        }
    }
}
