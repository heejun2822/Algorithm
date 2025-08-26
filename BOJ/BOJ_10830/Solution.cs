namespace Algorithm.BOJ.BOJ_10830
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10830/input1.txt",
            "BOJ/BOJ_10830/input2.txt",
            "BOJ/BOJ_10830/input3.txt",
        ];

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
                for (int j = 0; j < N; j++) A[i, j] = int.Parse(row[j]) % 1000;
            }

            int[,] R = MatPow(N, A, B);
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

        private static int[,] MatPow(int N, int[,] A, long B)
        {
            if (B == 1) return A;

            int[,] P = MatPow(N, A, B / 2);
            int[,] R = MatMul(N, P, P);

            if (B % 2 == 0) return R;
            return MatMul(N, R, A);
        }

        private static int[,] MatMul(int N, int[,] X, int[,] Y)
        {
            int[,] R = new int[N, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N; k++) R[i, j] += X[i, k] * Y[k, j];
                    R[i, j] %= 1000;
                }
            return R;
        }
    }
}
