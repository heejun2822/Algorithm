namespace Algorithm.BOJ.BOJ_01717
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01717/input.txt",
        ];

        // roots[x] >= 0 인 경우, roots[x]는 x의 root node를 나타낸다.
        // roots[x] < 0 인 경우, x는 root node이고 |roots[x]|는 x 트리의 rank(depth)를 나타낸다.
        // Find 과정에서의 경로 압축 최적화와 Union 과정에서의 랭크 최적화가 서로 영향을 주기 때문에
        // 모든 시점에서 roots[x]가 정확히 x의 root node이거나 x 트리의 정확한 rank임을 보장하는 것은 아니다.
        private static int[] roots = {};

        // 유니온 파인드 (Union Find)
        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nm = sr.ReadLine()!.Split();
            int n = int.Parse(nm[0]);
            int m = int.Parse(nm[1]);

            roots = new int[n + 1];
            Array.Fill(roots, -1);

            for (int _ = 0; _ < m; _++)
            {
                string[] oab = sr.ReadLine()!.Split();
                int o = int.Parse(oab[0]);
                int a = int.Parse(oab[1]);
                int b = int.Parse(oab[2]);

                if (o == 0) Union(a, b);
                else sw.WriteLine(Find(a) == Find(b) ? "YES" : "NO");
            }

            sr.Close();
            sw.Close();
        }

        private static void Union(int a, int b)
        {
            if ((a = Find(a)) == (b = Find(b))) return;

            if (roots[a] == roots[b]) roots[a]--;

            if (roots[a] < roots[b]) roots[b] = a;
            else roots[a] = b;
        }

        private static int Find(int a)
        {
            return roots[a] < 0 ? a : (roots[a] = Find(roots[a]));
        }
    }
}
