namespace Algorithm.BOJ.BOJ_05953
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_05953/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            int consecutiveSum = 0;
            int maxConsecutiveSum = int.MinValue;

            for (int _ = 0; _ < N; _++)
            {
                int P = int.Parse(sr.ReadLine()!);

                if (consecutiveSum >= 0)
                    consecutiveSum += P;
                else
                    consecutiveSum = P;

                maxConsecutiveSum = Math.Max(maxConsecutiveSum, consecutiveSum);
            }

            sw.WriteLine(maxConsecutiveSum);

            sr.Close();
            sw.Close();
        }
    }
}
