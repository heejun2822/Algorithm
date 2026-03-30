namespace Algorithm.BOJ.BOJ_28252
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_28252/input1.txt",
            "BOJ/BOJ_28252/input2.txt",
            "BOJ/BOJ_28252/input3.txt",
            "BOJ/BOJ_28252/input4.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int[] A = new int[N];

            for (int i = 0; i < N; i++)
                A[i] = ReadInt(sr);

            if (A[^1] > 2 || (N >= 2 && A[^1] == 1 && A[^2] == 1))
            {
                sw.WriteLine(-1);
                goto End;
            }

            int M = 0;
            System.Text.StringBuilder edges = new();

            M += A[^1];
            if (A[^1] == 2)
                edges.AppendLine("1 2");

            for (int i = N - 2; i >= 0; i--)
            {
                if (A[i] < A[i + 1])
                {
                    sw.WriteLine(-1);
                    goto End;
                }

                int firstLeafNode = M - A[i + 1] + 1;
                int lastLeafNode = M;
                int node = M + 1;
                M += A[i];

                for (int leafNode = firstLeafNode; leafNode <= lastLeafNode; leafNode++)
                    edges.AppendLine($"{leafNode} {node++}");
                while (node <= M)
                    edges.AppendLine($"{lastLeafNode} {node++}");
            }

            sw.WriteLine(M);
            sw.Write(edges);

            End:
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
