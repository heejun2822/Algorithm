namespace Algorithm.BOJ.BOJ_11444
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11444/input.txt",
        ];

        private static readonly int D = 1000000007;
        private static int[,] TempMat = new int[2, 2];

        public static void Run(string[] args)
        {
            long n = long.Parse(Console.ReadLine()!);
            Console.WriteLine(Factorial(n));
        }

        private static int Factorial(long n)
        {
            int[,] F = new int[,] {{1, 0}};
            int[,] M = new int[,] {{1, 1}, {1, 0}};

            if (n > 1)
            {
                int[,] R = new int[2, 2];
                MatPow(M, n - 1, R);
                MatMul(F, R);
            }
            return F[0, 0];
        }

        private static void MatPow(int[,] M, long n, int[,] R)
        {
            if (n == 1)
            {
                MatCopy(R, M);
                return;
            }

            MatPow(M, n / 2, R);
            MatMul(R, R);
            if (n % 2 == 1) MatMul(R, M);
        }

        private static void MatMul(int[,] M1, int[,] M2)
        {
            for (int i = 0, m = M1.GetLength(0); i < m; i++)
            {
                for (int j = 0, n = M2.GetLength(1); j < n; j++)
                {
                    long temp = 0;
                    for (int k = 0, l = M1.GetLength(1); k < l; k++)
                    {
                        temp += (long)M1[i, k] * M2[k, j];
                    }
                    TempMat[i, j] = (int)(temp % D);
                }
            }
            MatCopy(M1, TempMat);
        }

        private static void MatCopy(int[,] M1, int[,] M2)
        {
            for (int i = 0, m = M1.GetLength(0); i < m; i++)
                for (int j = 0, n = M1.GetLength(1); j < n; j++)
                    M1[i, j] = M2[i, j];
        }
    }
}
