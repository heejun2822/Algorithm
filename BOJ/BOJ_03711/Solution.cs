namespace Algorithm.BOJ.BOJ_03711
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_03711/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            System.Text.StringBuilder output = new();

            for (int _ = 0; _ < N; _++)
            {
                int G = ReadInt(sr);
                int[] studentIDs = new int[G];
                for (int i = 0; i < G; i++)
                    studentIDs[i] = ReadInt(sr);

                int m = G;

                while (true)
                {
                    bool isDuplicated = false;
                    bool[] exists = new bool[m];

                    foreach (int id in studentIDs)
                    {
                        int r = id % m;
                        if (exists[r])
                        {
                            isDuplicated = true;
                            break;
                        }
                        exists[r] = true;
                    }

                    if (!isDuplicated) break;

                    m++;
                }

                output.AppendLine(m.ToString());
            }

            sw.Write(output);

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
