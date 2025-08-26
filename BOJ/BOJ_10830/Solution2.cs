namespace Algorithm.BOJ.BOJ_10830
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10830/input1.txt",
            "BOJ/BOJ_10830/input2.txt",
            "BOJ/BOJ_10830/input3.txt",
        ];

        private static int[,] TempMat = new int[0, 0];
        private static readonly int D = 1000;

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            string[] nb = sr.ReadLine()!.Split();
            int N = int.Parse(nb[0]);
            long B = long.Parse(nb[1]);
            int[,] A = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                string[] row = sr.ReadLine()!.Split();
                for (int j = 0; j < N; j++) A[i, j] = int.Parse(row[j]) % D;
            }
            TempMat = new int[N, N];

            int[,] R = new int[N, N];
            MatPow(N, A, B, R);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    sw.Write(R[i, j]);
                    sw.Write(" ");
                }
                sw.Write("\n");
            }

            sr.Close();
            sw.Close();
        }

        private static void MatPow(int N, int[,] mat, long exp, int[,] res)
        {
            if (exp == 1)
            {
                for (int i = 0; i < N; i++)
                    for (int j = 0; j < N; j++)
                        res[i, j] = mat[i, j];
                return;
            }

            MatPow(N, mat, exp / 2, res);
            MatMul(N, res, res);
            if (exp % 2 == 1) MatMul(N, res, mat);
        }

        private static void MatMul(int N, int[,] X, int[,] Y)
        {
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    TempMat[i, j] = 0;
                    for (int k = 0; k < N; k++) TempMat[i, j] += X[i, k] * Y[k, j];
                    TempMat[i, j] %= D;
                }
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    X[i, j] = TempMat[i, j];
        }
    }
}
