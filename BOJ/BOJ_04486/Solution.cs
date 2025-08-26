namespace Algorithm.BOJ.BOJ_04486
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04486/input.txt",
        ];

        public static void Run(string[] args)
        {
            int idx = 1;
            int N;

            while ((N = int.Parse(Console.ReadLine()!)) != 0)
            {
                System.Text.StringBuilder answer = new($"Case {idx++}:\n{N} pencils for {N} cents\n");

                bool hasSolution = false;

                for (int x = 1; x <= N - 2; x++)
                {
                    for (int y = 1; x + y <= N - 1; y++)
                    {
                        int z = N - x - y;

                        if (4 * x + y / 2f + z / 4f == N)
                        {
                            answer.AppendLine($"{x} at four cents each\n{y} at two for a penny\n{z} at four for a penny\n");
                            hasSolution = true;
                        }
                    }
                }

                if (!hasSolution)
                    answer.AppendLine("No solution found.\n");

                Console.Write(answer);
            }
        }
    }
}
