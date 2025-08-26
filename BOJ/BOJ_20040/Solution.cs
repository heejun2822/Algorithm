namespace Algorithm.BOJ.BOJ_20040
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20040/input1.txt",
            "BOJ/BOJ_20040/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nm = sr.ReadLine()!.Split();
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            int[] roots = new int[n];
            Array.Fill(roots, -1);

            int cycled = 0;

            for (int i = 1; i <= m; i++)
            {
                string[] points = sr.ReadLine()!.Split();
                if (!Union(int.Parse(points[0]), int.Parse(points[1])))
                {
                    cycled = i;
                    break;
                }
            }

            sw.WriteLine(cycled);

            sr.Close();
            sw.Close();

            bool Union(int A, int B)
            {
                A = Find(A);
                B = Find(B);

                if (A == B) return false;

                if (roots[A] == roots[B]) roots[A]--;

                if (roots[A] < roots[B]) roots[B] = A;
                else roots[A] = B;

                return true;
            }

            int Find(int A)
            {
                return roots[A] < 0 ? A : (roots[A] = Find(roots[A]));
            }
        }
    }
}
