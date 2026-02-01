namespace Algorithm.BOJ.BOJ_25712
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25712/input1.txt",
            "BOJ/BOJ_25712/input2.txt",
            "BOJ/BOJ_25712/input3.txt",
            "BOJ/BOJ_25712/input4.txt",
            "BOJ/BOJ_25712/input5.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr);
            int[] inputLengths = new int[M];

            for (int i = 0; i < M; i++)
                inputLengths[i] = ReadInt(sr) / 2;

            (int l, int h)[] prevRanges = new (int, int)[10];
            int prevCnt = 0;
            (int l, int h)[] currRanges = new (int, int)[10];
            int currCnt = 0;

            int col = 0;

            for (int i = 0; i < inputLengths[col]; i++)
                currRanges[currCnt++] = (ReadInt(sr), ReadInt(sr));

            while (++col < M && currCnt > 0)
            {
                (prevRanges, currRanges) = (currRanges, prevRanges);
                (prevCnt, currCnt) = (currCnt, 0);

                for (int i = 0; i < inputLengths[col]; i++)
                {
                    int l = ReadInt(sr), h = ReadInt(sr);

                    for (int j = 0; j < prevCnt; j++)
                    {
                        if (l <= prevRanges[j].h && h >= prevRanges[j].l)
                        {
                            currRanges[currCnt++] = (l, h);
                            break;
                        }
                    }
                }
            }

            sw.WriteLine(currCnt > 0 ? "YES" : "NO");

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
