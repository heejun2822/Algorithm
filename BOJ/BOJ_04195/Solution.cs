namespace Algorithm.BOJ.BOJ_04195
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04195/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            Dictionary<string, int> userIds = new();
            List<int> roots = new();

            for (int _ = 0; _ < T; _++)
            {
                int F = int.Parse(sr.ReadLine()!);

                userIds.Clear();
                roots.Clear();

                for (int i = 0; i < F; i++)
                {
                    string[] users = sr.ReadLine()!.Split();
                    foreach (string user in users)
                    {
                        if (userIds.ContainsKey(user)) continue;
                        userIds.Add(user, userIds.Count);
                        roots.Add(-1);
                    }

                    sw.WriteLine(Union(userIds[users[0]], userIds[users[1]]));
                }
            }

            sr.Close();
            sw.Close();

            int Union(int A, int B)
            {
                A = Find(A);
                B = Find(B);

                if (A != B)
                {
                    roots[A] += roots[B];
                    roots[B] = A;
                }

                return -roots[A];
            }

            int Find(int A)
            {
                return roots[A] < 0 ? A : (roots[A] = Find(roots[A]));
            }
        }
    }
}
