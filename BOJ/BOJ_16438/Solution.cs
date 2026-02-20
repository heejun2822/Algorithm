namespace Algorithm.BOJ.BOJ_16438
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16438/input1.txt",
            "BOJ/BOJ_16438/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder output = new((N + 2) * 7);
            int gap = 1;

            for (int _ = 0; _ < 7; _++)
            {
                char team = 'B';

                for (int i = 0; i < N; i++)
                {
                    output.Append(team);
                    if (i % gap == 0)
                        team = team == 'A' ? 'B' : 'A';
                }

                output.AppendLine();
                gap *= 2;
            }

            Console.Write(output);
        }
    }
}
