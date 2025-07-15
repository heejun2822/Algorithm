namespace Algorithm.BOJ.BOJ_28103
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_28103/input1.txt",
            "BOJ/BOJ_28103/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nmx = sr.ReadLine()!.Split();
            long N = long.Parse(nmx[0]);
            int M = int.Parse(nmx[1]);
            long X = long.Parse(nmx[2]);

            int[] a = new int[M];

            for (int i = 0; i < M; i++)
                a[i] = ReadInt(sr);

            System.Text.StringBuilder output = new();

            for (int i = 0; i < M - 1; i++)
            {
                long cnt = Math.Min((X - a[^1] * N) / (a[i] - a[^1]), N);
                output.Append(cnt).Append(' ');
                N -= cnt;
                X -= cnt * a[i];
            }
            output.Append(N);

            sw.WriteLine(output);

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
