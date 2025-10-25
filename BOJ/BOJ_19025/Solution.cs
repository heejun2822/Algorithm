namespace Algorithm.BOJ.BOJ_19025
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_19025/input.txt",
        ];

        public static void Run(string[] args)
        {
            Dictionary<int, int> digitMap = new()
            {
                { Convert.ToInt32("1110111", 2), 0 },
                { Convert.ToInt32("0010010", 2), 1 },
                { Convert.ToInt32("1011101", 2), 2 },
                { Convert.ToInt32("1011011", 2), 3 },
                { Convert.ToInt32("0111010", 2), 4 },
                { Convert.ToInt32("1101011", 2), 5 },
                { Convert.ToInt32("1101111", 2), 6 },
                { Convert.ToInt32("1010010", 2), 7 },
                { Convert.ToInt32("1111111", 2), 8 },
                { Convert.ToInt32("1111011", 2), 9 },
            };
            (int r, int c)[] segments = { (6, 1), (4, 3), (4, 0), (3, 1), (1, 3), (1, 0), (0, 1) };
            int[] offset = { 0, 5, 12, 17 };

            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);
            bool[,] lit = new bool[7, 21];

            System.Text.StringBuilder output = new();

            while (T-- > 0)
            {
                for (int i = 0; i < 7; i++)
                {
                    string input = sr.ReadLine()!;
                    for (int j = 0; j < 21; j++)
                        lit[i, j] = input[j] == 'X';
                }

                int[] digits = new int[4];

                for (int i = 0; i < 4; i++)
                {
                    int mask = 0;
                    for (int j = 0; j < 7; j++)
                        if (lit[segments[j].r, segments[j].c + offset[i]])
                            mask |= 1 << j;
                    digits[i] = digitMap[mask];
                }

                output.AppendLine($"{digits[0]}{digits[1]}:{digits[2]}{digits[3]}");
            }

            sw.Write(output);

            sr.Close();
            sw.Close();
        }
    }
}
