namespace Algorithm.BOJ.BOJ_11728
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11728/input1.txt",
            "BOJ/BOJ_11728/input2.txt",
            "BOJ/BOJ_11728/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr);
            int[] A = new int[N];
            int[] B = new int[M];

            for (int i = 0; i < N; i++)
                A[i] = ReadInt(sr);
            for (int i = 0; i < M; i++)
                B[i] = ReadInt(sr);

            System.Text.StringBuilder output = new();

            int idxA = 0, idxB = 0;

            while (idxA < N && idxB < M)
                output.Append(A[idxA] < B[idxB] ? A[idxA++] : B[idxB++]).Append(' ');
            while (idxA < N)
                output.Append(A[idxA++]).Append(' ');
            while (idxB < M)
                output.Append(B[idxB++]).Append(' ');

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
