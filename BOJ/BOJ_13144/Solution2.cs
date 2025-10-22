namespace Algorithm.BOJ.BOJ_13144
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13144/input1.txt",
            "BOJ/BOJ_13144/input2.txt",
            "BOJ/BOJ_13144/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
                arr[i] = ReadInt(sr);

            long cnt = 0;
            int l = 0, r = 0;

            int[] indices = new int[100_001];
            Array.Fill(indices, -1);

            while (r < N)
            {
                if (indices[arr[r]] != -1)
                    l = Math.Max(l, indices[arr[r]] + 1);
                indices[arr[r]] = r;
                cnt += ++r - l;
            }

            sw.WriteLine(cnt);

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
