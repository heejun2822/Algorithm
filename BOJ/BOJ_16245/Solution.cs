namespace Algorithm.BOJ.BOJ_16245
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16245/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = ReadInt(sr), k = ReadInt(sr);

            bool[,] isTaken = new bool[n + 1, 3];
            (int x, int y)[] preferredSeat = new (int, int)[4];
            List<int>[] passengers = new List<int>[4];

            int minX = 1, maxX = n;

            for (int r = 0; r < 4; r++)
                passengers[r] = new();

            for (int i = 1; i <= k; i++)
            {
                int x = ReadInt(sr), y = ReadInt(sr);

                UpdatePreferredSeat();

                for (int r = 0; r < 4; r++)
                    if (preferredSeat[r] == (x, y))
                        passengers[r].Add(i);

                isTaken[x, y] = true;
            }

            for (int r = 0; r < 4; r++)
            {
                sw.Write(passengers[r].Count);
                foreach (int i in passengers[r])
                    sw.Write(" " + i);
                sw.WriteLine();
            }
            sw.Write(k);
            for (int i = 1; i <= k; i++)
                sw.Write(" " + i);
            sw.WriteLine();

            sr.Close();
            sw.Close();

            void UpdatePreferredSeat()
            {
                while (isTaken[minX, 1] && isTaken[minX, 2])
                    minX++;
                while (isTaken[maxX, 1] && isTaken[maxX, 2])
                    maxX--;

                preferredSeat[0] = !isTaken[minX, 1] ? (minX, 1) : (minX, 2);
                preferredSeat[1] = !isTaken[minX, 2] ? (minX, 2) : (minX, 1);
                preferredSeat[2] = !isTaken[maxX, 1] ? (maxX, 1) : (maxX, 2);
                preferredSeat[3] = !isTaken[maxX, 2] ? (maxX, 2) : (maxX, 1);
            }
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
