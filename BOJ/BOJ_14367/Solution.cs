namespace Algorithm.BOJ.BOJ_14367
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14367/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder output = new();

            for (int x = 1; x <= T; x++)
            {
                string[] input = Console.ReadLine()!.Split();
                int J = int.Parse(input[0]);
                int P = int.Parse(input[1]);
                int S = int.Parse(input[2]);
                int K = int.Parse(input[3]);

                int M = Math.Min(S, K);

                int y = J * P * M;
                output.AppendLine($"Case #{x}: {y}");

                for (int j = 0; j < J; j++)
                {
                    for (int p = 0; p < P; p++)
                    {
                        int s = (j + p) % S;
                        for (int _ = 0; _ < M; _++)
                        {
                            output.AppendLine($"{j + 1} {p + 1} {s + 1}");
                            s = (s + 1) % S;
                        }
                    }
                }
            }

            Console.Write(output);
        }
    }
}
