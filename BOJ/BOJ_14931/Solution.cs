namespace Algorithm.BOJ.BOJ_14931
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_14931/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int L = int.Parse(sr.ReadLine()!);
            int[] points = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            long maxScore = 0;
            int optD = 0;

            for (int d = 1; d <= L; d++)
            {
                long score = 0;

                for (int i = d - 1; i < L; i += d)
                    score += points[i];

                if (score > maxScore)
                {
                    maxScore = score;
                    optD = d;
                }
            }

            sw.WriteLine($"{optD} {maxScore}");

            sr.Close();
            sw.Close();
        }
    }
}
