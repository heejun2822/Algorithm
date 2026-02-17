namespace Algorithm.BOJ.BOJ_03123
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_03123/input1.txt",
            "BOJ/BOJ_03123/input2.txt",
            "BOJ/BOJ_03123/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int X = ReadInt(sr), Y = ReadInt(sr);
            bool[,] roof = new bool[X + 1, Y + 1];
            int N = ReadInt(sr);

            for (int _ = 0; _ < N; _++)
            {
                int x = ReadInt(sr), y = ReadInt(sr);
                roof[x, y] = true;
            }

            double[] areas = { 1, Math.PI / 6 + Math.Sqrt(3) / 4, Math.PI / 4 };
            int[] counts = new int[3];

            for (int r = 0; r < X; r++)
            {
                for (int c = 0; c < Y; c++)
                {
                    int cnt = 0;
                    if (roof[r, c]) cnt++;
                    if (roof[r, c + 1]) cnt++;
                    if (roof[r + 1, c]) cnt++;
                    if (roof[r + 1, c + 1]) cnt++;

                    if (cnt >= 3)
                        counts[0]++;
                    else if (cnt == 2)
                        counts[(roof[r, c] && roof[r + 1, c + 1]) || (roof[r, c + 1] && roof[r + 1, c]) ? 0 : 1]++;
                    else if (cnt == 1)
                        counts[2]++;
                }
            }

            double totalArea = 0;

            for (int i = 0; i < 3; i++)
                totalArea += areas[i] * counts[i];

            sw.WriteLine(totalArea);

            sr.Close();
            sw.Close();
        }

        private static int ReadInt(StreamReader sr)
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { sr.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
