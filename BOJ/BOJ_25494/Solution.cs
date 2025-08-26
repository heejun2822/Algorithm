namespace Algorithm.BOJ.BOJ_25494
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25494/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            for (int _ = 0; _ < T; _++)
            {
                string[] abc = Console.ReadLine()!.Split();
                int a = int.Parse(abc[0]);
                int b = int.Parse(abc[1]);
                int c = int.Parse(abc[2]);

                int cnt = 0;
                for (int x = 1; x <= a; x++)
                {
                    for (int y = 1; y <= b; y++)
                    {
                        int r = x % y;
                        for (int z = 1; z <= c; z++)
                        {
                            if (y % z == r && z % x == r) cnt++;
                        }
                    }
                }

                Console.WriteLine(cnt);
            }
        }
    }
}
