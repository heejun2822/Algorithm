namespace Algorithm.BOJ.BOJ_06609
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06609/input.txt",
        ];

        public static void Run(string[] args)
        {
            System.Text.StringBuilder output = new();

            string? line;

            while ((line = Console.ReadLine()) != null)
            {
                string[] input = line.Split();
                int M = int.Parse(input[0]);
                int P = int.Parse(input[1]);
                int L = int.Parse(input[2]);
                int E = int.Parse(input[3]);
                int R = int.Parse(input[4]);
                int S = int.Parse(input[5]);
                int N = int.Parse(input[6]);

                for (int _ = 0; _ < N; _++)
                    (M, P, L) = (P / S, L / R, M * E);

                output.AppendLine(M.ToString());
            }

            Console.Write(output);
        }
    }
}
