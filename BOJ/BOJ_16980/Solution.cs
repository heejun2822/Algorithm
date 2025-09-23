namespace Algorithm.BOJ.BOJ_16980
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16980/input1.txt",
            "BOJ/BOJ_16980/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] input = sr.ReadLine()!.Split();
            int H = int.Parse(input[0]), W = int.Parse(input[1]);

            List<(int r, int c)> jewels = new();
            int[,] accOrbCnt = new int[H + 1, W + 1];
            int[,] accIngotCnt = new int[H + 1, W + 1];

            for (int r = 1; r <= H; r++)
            {
                for (int c = 1; c <= W; c++)
                {
                    accOrbCnt[r, c] = accOrbCnt[r, c - 1];
                    accIngotCnt[r, c] = accIngotCnt[r - 1, c];

                    int type = sr.Read();

                    if (type == 'J')
                        jewels.Add((r, c));
                    else if (type == 'O')
                        accOrbCnt[r, c]++;
                    else if (type == 'I')
                        accIngotCnt[r, c]++;
                }

                while (true)
                {
                    int c = sr.Read();
                    if (c == '\n' || c == -1) break;
                    if (c == '\r') { sr.Read(); break; }
                }
            }

            long power = 0;

            foreach ((int r, int c) in jewels)
            {
                int orbCnt = accOrbCnt[r, W] - accOrbCnt[r, c];
                int ingotCnt = accIngotCnt[H, c] - accIngotCnt[r, c];
                power += orbCnt * ingotCnt;
            }

            sw.WriteLine(power);

            sr.Close();
            sw.Close();
        }
    }
}
