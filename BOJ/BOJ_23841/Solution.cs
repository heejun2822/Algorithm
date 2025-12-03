namespace Algorithm.BOJ.BOJ_23841
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_23841/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            System.Text.StringBuilder output = new();

            for (int _ = 0; _ < N; _++)
            {
                string row = Console.ReadLine()!;

                for (int i = 0; i < M; i++)
                    output.Append(row[i] != '.' ? row[i] : row[M - 1 - i]);
                output.AppendLine();
            }

            Console.Write(output);
        }
    }
}
