namespace Algorithm.BOJ.BOJ_02897
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02897/input1.txt",
            "BOJ/BOJ_02897/input2.txt",
            "BOJ/BOJ_02897/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] rc = Console.ReadLine()!.Split();
            int R = int.Parse(rc[0]);
            int C = int.Parse(rc[1]);

            string[] parkingLot = new string[R];
            for (int i = 0; i < R; i++) parkingLot[i] = Console.ReadLine()!;

            int[] counts = new int[5];

            for (int i = 0; i < R - 1; i++)
            {
                for (int j = 0; j < C - 1; j++)
                {
                    int cnt = CountCars(i, j);
                    if (cnt >= 0) counts[cnt]++;
                }
            }

            for (int i = 0; i < 5; i++)
                Console.WriteLine(counts[i]);

            int CountCars(int r, int c)
            {
                int cnt = 0;
                for (int i = r; i <= r + 1; i++)
                {
                    for (int j = c; j <= c + 1; j++)
                    {
                        if (parkingLot[i][j] == '#') return -1;
                        if (parkingLot[i][j] == 'X') cnt++;
                    }
                }
                return cnt;
            }
        }
    }
}
