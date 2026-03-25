namespace Algorithm.BOJ.BOJ_30080
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30080/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string S = Console.ReadLine()!;

            byte[] houses = new byte[N];

            for (int i = 0; i < N; i++)
                houses[i] = (byte)(S[i] == 'H' ? 1 : 0);

            (int cnt, int lowerLimitIdx)[] counts = new (int, int)[1 << 8];
            byte train = 0;
            int maxCnt = 0;
            byte maxTrain = 0;

            for (int i = 0; i < 7; i++)
            {
                train <<= 1;
                train += houses[i];
            }

            for (int i = 7; i < N; i++)
            {
                train <<= 1;
                train += houses[i];

                if (i - 7 < counts[train].lowerLimitIdx) continue;

                counts[train].cnt += 8;
                counts[train].lowerLimitIdx = i + 1;

                if (counts[train].cnt > maxCnt)
                {
                    maxCnt = counts[train].cnt;
                    maxTrain = train;
                }
            }

            Console.WriteLine(maxCnt);
            Console.WriteLine(Convert.ToString(maxTrain, 2).PadLeft(8, '0').Replace('1', 'H').Replace('0', 'O'));
        }
    }
}
