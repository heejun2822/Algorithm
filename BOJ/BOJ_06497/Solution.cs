namespace Algorithm.BOJ.BOJ_06497
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_06497/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int[] roots;

            while (true)
            {
                string[] mn = sr.ReadLine()!.Split();
                int M = int.Parse(mn[0]);
                int N = int.Parse(mn[1]);

                if (M == 0 && N == 0) break;

                (int z, int x, int y)[] roads = new (int, int, int)[N];

                for (int i = 0; i < N; i++)
                {
                    string[] xyz = sr.ReadLine()!.Split();
                    roads[i] = (int.Parse(xyz[2]), int.Parse(xyz[0]), int.Parse(xyz[1]));
                }
                Array.Sort(roads);

                roots = new int[M];
                Array.Fill(roots, -1);

                int savedCost = 0;

                foreach ((int z, int x, int y) in roads)
                    if (!Union(x, y)) savedCost += z;

                sw.WriteLine(savedCost);
            }

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
