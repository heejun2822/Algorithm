namespace Algorithm.BOJ.BOJ_09027
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09027/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = ReadInt(sr);

            while (T-- > 0)
            {
                int N = ReadInt(sr);

                int[] locations = new int[N + 1];
                int[] accFanCounts = new int[N + 1];
                long totalDistance = 0;

                for (int i = 1; i <= N; i++)
                {
                    locations[i] = ReadInt(sr);
                }
                for (int i = 1; i <= N; i++)
                {
                    int fanCnt = ReadInt(sr);
                    accFanCounts[i] = accFanCounts[i - 1] + fanCnt;
                    totalDistance += locations[i] * fanCnt;
                }

                long minTotalDistance = totalDistance;
                int optLocation = 0;

                for (int i = 1; i <= N; i++)
                {
                    long dl = locations[i] - locations[i - 1];
                    totalDistance += accFanCounts[i - 1] * dl;
                    totalDistance -= (accFanCounts[N] - accFanCounts[i - 1]) * dl;

                    if (totalDistance < minTotalDistance)
                    {
                        minTotalDistance = totalDistance;
                        optLocation = locations[i];
                    }
                }

                sw.WriteLine(optLocation);
            }

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
