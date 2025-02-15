namespace Algorithm.BOJ.BOJ_01270
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01270/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine()!);

            for (int i = 0; i < n; i++)
            {
                string[] input = sr.ReadLine()!.Split();
                int T = int.Parse(input[0]);

                Dictionary<long, int> counts = new();

                string output = "SYJKGW";

                for (int j = 1; j <= T; j++)
                {
                    long N = long.Parse(input[j]);

                    if (!counts.TryAdd(N, 1)) counts[N]++;

                    if (counts[N] > T / 2)
                    {
                        output = N.ToString();
                        break;
                    }
                }

                sw.WriteLine(output);
            }

            sr.Close();
            sw.Close();
        }
    }
}
