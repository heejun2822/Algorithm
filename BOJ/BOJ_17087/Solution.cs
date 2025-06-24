namespace Algorithm.BOJ.BOJ_17087
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_17087/input1.txt",
            "BOJ/BOJ_17087/input2.txt",
            "BOJ/BOJ_17087/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), S = ReadInt(sr);

            int X = S;
            int A = ReadInt(sr);
            int D = Math.Abs(A - X);

            for (int _ = 1; _ < N; _++)
            {
                X = A;
                A = ReadInt(sr);
                D = GCD(D, Math.Abs(A - X));
            }

            sw.WriteLine(D);

            sr.Close();
            sw.Close();

            int GCD(int a, int b)
            {
                return b == 0 ? a : GCD(b, a % b);
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
