namespace Algorithm.BOJ.BOJ_02890
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02890/input1.txt",
            "BOJ/BOJ_02890/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] rc = Console.ReadLine()!.Split();
            int R = int.Parse(rc[0]);
            int C = int.Parse(rc[1]);

            (int n, int d)[] records = new (int, int)[9];
            for (int i = 0; i < R; i++)
            {
                string lane = Console.ReadLine()!;
                for (int j = 0; j < C - 4; j++)
                {
                    char p = lane[C - 2 - j];
                    if (p != '.')
                    {
                        records[p - '1'] = (p - '1', j);
                        break;
                    }
                }
            }
            Array.Sort(records, (a, b) => a.d - b.d);

            int[] rankings = new int[9];
            int rank = 1;
            rankings[records[0].n] = rank;
            for (int i = 1; i < 9; i++)
                rankings[records[i].n] = records[i].d == records[i - 1].d ? rank : ++rank;

            for (int i = 0; i < 9; i++) Console.WriteLine(rankings[i]);
        }
    }
}
