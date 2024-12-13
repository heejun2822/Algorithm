namespace Algorithm.BOJ.BOJ_09461
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09461/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            long[] P = new long[101];
            P[0] = 0;
            P[1] = P[2] = P[3] = 1;
            P[4] = 2;
            int idx = 5;

            for (int _ = 0; _ < T; _++)
            {
                int N = int.Parse(Console.ReadLine()!);
                while (idx <= N)
                {
                    P[idx] = P[idx - 1] + P[idx - 5];
                    idx++;
                }
                Console.WriteLine(P[N]);
            }
        }
    }
}
