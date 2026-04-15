namespace Algorithm.BOJ.BOJ_31823
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31823/input1.txt",
            "BOJ/BOJ_31823/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]), M = int.Parse(input[1]);

            HashSet<int> streakSet = new();
            System.Text.StringBuilder output = new();

            for (int _ = 0; _ < N; _++)
            {
                input = Console.ReadLine()!.Split();

                int maxStreak = 0;
                int streak = 0;

                for (int i = 0; i < M; i++)
                {
                    if (input[i] == ".")
                        maxStreak = Math.Max(maxStreak, ++streak);
                    else
                        streak = 0;
                }

                streakSet.Add(maxStreak);
                output.AppendLine($"{maxStreak} {input[M]}");
            }

            Console.WriteLine(streakSet.Count);
            Console.Write(output);
        }
    }
}
