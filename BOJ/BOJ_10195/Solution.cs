namespace Algorithm.BOJ.BOJ_10195
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10195/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            for (int tc = 1; tc <= T; tc++)
            {
                Console.WriteLine($"Case: {tc}");

                string[] input = Console.ReadLine()!.Split();
                int tunnelDepth = int.Parse(input[2]);
                int tunnelLength = int.Parse(input[4]);

                int[] stalagmites = new int[tunnelLength];
                int stalagmiteCnt = int.Parse(Console.ReadLine()!.Split()[1]);

                for (int i = 0; i < stalagmiteCnt; i++)
                {
                    input = Console.ReadLine()!.Split();
                    int size = int.Parse(input[2]);
                    int distance = int.Parse(input[5]);

                    stalagmites[distance] = size;
                }

                int sequenceCnt = int.Parse(Console.ReadLine()!.Split()[1]);

                for (int _ = 0; _ < sequenceCnt; _++)
                {
                    string sequence = Console.ReadLine()!.Split()[2];

                    int distance = 0;
                    int depth = 0;
                    string outcome = "Reached end of tunnel";

                    foreach (char c in sequence)
                    {
                        distance++;
                        if (c == '^')
                            depth--;
                        else if (c == 'v')
                            depth++;

                        if (depth < 0)
                        {
                            outcome = "Crashed into tunnel ceiling";
                            break;
                        }
                        if (depth >= tunnelDepth)
                        {
                            outcome = "Crashed into tunnel floor";
                            break;
                        }
                        if (depth >= tunnelDepth - stalagmites[distance])
                        {
                            outcome = "Crashed into stalagmite";
                            break;
                        }
                    }

                    Console.WriteLine($"Sequence {sequence} {outcome}");
                }

                Console.ReadLine();
            }
        }
    }
}
