namespace Algorithm.BOJ.BOJ_30803
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30803/input1.txt",
            "BOJ/BOJ_30803/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            int[] A = new int[N + 1];
            long totalA = 0;

            for (int i = 1; i <= N; i++)
            {
                A[i] = ReadInt(sr);
                totalA += A[i];
            }

            System.Text.StringBuilder answer = new($"{totalA}\n");

            int Q = ReadInt(sr);

            for (int _ = 0; _ < Q; _++)
            {
                if (ReadInt(sr) == 1)
                {
                    int i = ReadInt(sr), x = ReadInt(sr);

                    if (A[i] > 0)
                    {
                        totalA += x - A[i];
                        A[i] = x;
                    }
                    else
                    {
                        A[i] = -x;
                    }
                }
                else
                {
                    int i = ReadInt(sr);

                    totalA += A[i] = -A[i];
                }

                answer.AppendLine(totalA.ToString());
            }

            sw.Write(answer);

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
