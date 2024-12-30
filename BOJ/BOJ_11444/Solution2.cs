namespace Algorithm.BOJ.BOJ_11444
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11444/input.txt",
        ];

        private static readonly int D = 1000000007;

        public static void Run(string[] args)
        {
            long n = long.Parse(Console.ReadLine()!);
            Console.WriteLine(Factorial(n));
        }

        private static int Factorial(long n)
        {
            int[,] F = new int[,] {{1, 0}};
            int[,] M = new int[,] {{1, 1}, {1, 0}};

            if (n > 1) F = MatMul(F, MatPow(M, n - 1));
            return F[0, 0];
        }

        private static int[,] MatPow(int[,] M, long n)
        {
            if (n == 1) return MatCopy(M);

            int[,] R = MatPow(M, n / 2);
            R = MatMul(R, R);
            if (n % 2 == 1) R = MatMul(R, M);
            return R;
        }

        private static int[,] MatMul(int[,] A, int[,] B)
        {
            int m = A.GetLength(0);
            int n = B.GetLength(1);
            int l = A.GetLength(1);

            int[,] M = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    long temp = 0;
                    for (int k = 0; k < l; k++)
                    {
                        temp += (long)A[i, k] * B[k, j];
                    }
                    M[i, j] = (int)(temp % D);
                }
            }
            return M;
        }

        private static int[,] MatCopy(int[,] M)
        {
            int m = M.GetLength(0);
            int n = M.GetLength(1);
            int[,] C = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    C[i, j] = M[i, j];
            return C;
        }
    }
}
