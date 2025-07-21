namespace Algorithm.BOJ.BOJ_16401
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_16401/input1.txt",
            "BOJ/BOJ_16401/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int M = ReadInt(sr), N = ReadInt(sr);
            int[] L = new int[N];

            for (int i = 0; i < N; i++)
                L[i] = ReadInt(sr);

            Array.Sort(L, (a, b) => b - a);

            int low = 0, high = L[0];

            while (low < high)
            {
                int mid = (low + high + 1) / 2;
                int cnt = 0;

                for (int i = 0; i < N; i++)
                {
                    if (L[i] < mid) break;
                    if ((cnt += L[i] / mid) >= M) break;
                }

                if (cnt >= M) low = mid;
                else high = mid - 1;
            }

            sw.WriteLine(high);

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
