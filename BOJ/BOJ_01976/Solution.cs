namespace Algorithm.BOJ.BOJ_01976
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01976/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);
            int M = int.Parse(sr.ReadLine()!);

            int[] roots = new int[N + 1];
            Array.Fill(roots, -1);

            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    if (sr.Read() == '1') Union(i, j);
                    sr.Read();
                }
            }

            int[] tourCities = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
            int rootCity = Find(tourCities[0]);
            string result = "YES";

            for (int i = 1; i < M; i++)
            {
                if (Find(tourCities[i]) != rootCity)
                {
                    result = "NO";
                    break;
                }
            }

            sw.WriteLine(result);

            sr.Close();
            sw.Close();

            void Union(int A, int B)
            {
                A = Find(A);
                B = Find(B);

                if (A == B) return;

                if (roots[A] == roots[B]) roots[A]--;

                if (roots[A] < roots[B]) roots[B] = A;
                else roots[A] = B;
            }

            int Find(int A)
            {
                return roots[A] < 0 ? A : (roots[A] = Find(roots[A]));
            }
        }
    }
}
