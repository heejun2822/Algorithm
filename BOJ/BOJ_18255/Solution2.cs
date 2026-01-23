namespace Algorithm.BOJ.BOJ_18255
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_18255/input.txt",
        ];

        public static void Run(string[] args)
        {
            int[,] GCMTable = new int[101, 101];

            int T = int.Parse(Console.ReadLine()!);

            while (T-- > 0)
            {
                int N = int.Parse(Console.ReadLine()!);

                int cnt = 0;

                for (int x = 0; x <= N; x++)
                    for (int y = 0; y <= N; y++)
                        for (int z = 0; z <= N; z++)
                            if (IsVisible(x, y, z))
                                cnt++;

                Console.WriteLine(cnt);
            }

            bool IsVisible(int x, int y, int z)
            {
                int gcm = 0;
                if (x > 0)
                    gcm = gcm == 0 ? x : CalcGCM(gcm, x);
                if (y > 0)
                    gcm = gcm == 0 ? y : CalcGCM(gcm, y);
                if (z > 0)
                    gcm = gcm == 0 ? z : CalcGCM(gcm, z);

                return gcm == 1;
            }

            int CalcGCM(int a, int b)
            {
                if (GCMTable[a, b] == 0)
                {
                    int r = a % b;
                    GCMTable[a, b] = GCMTable[b, a] = r == 0 ? b : CalcGCM(b, r);
                }
                return GCMTable[a, b];
            }
        }
    }
}
