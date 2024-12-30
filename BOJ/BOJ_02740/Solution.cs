namespace Algorithm.BOJ.BOJ_02740
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02740/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            string[] nm = sr.ReadLine()!.Split();
            int N = int.Parse(nm[0]), M = int.Parse(nm[1]);
            int[,] A = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                string[] row = sr.ReadLine()!.Split();
                for (int j = 0; j < M; j++) A[i, j] = int.Parse(row[j]);
            }
            string[] mk = sr.ReadLine()!.Split();
            int K = int.Parse(mk[1]);
            int[,] B = new int[M, K];
            for (int i = 0; i < M; i++)
            {
                string[] row = sr.ReadLine()!.Split();
                for (int j = 0; j < K; j++) B[i, j] = int.Parse(row[j]);
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    int ele = 0;
                    for (int l = 0; l < M; l++) ele += A[i, l] * B[l, j];
                    sw.Write(ele);
                    sw.Write(" ");
                }
                sw.Write("\n");
            }

            sr.Close();
            sw.Close();
        }
    }
}
