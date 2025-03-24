namespace Algorithm.BOJ.BOJ_05212
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_05212/input1.txt",
            "BOJ/BOJ_05212/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] rc = Console.ReadLine()!.Split();
            int R = int.Parse(rc[0]);
            int C = int.Parse(rc[1]);

            char[,] map = new char[R, C];
            for (int i = 0; i < R; i++)
            {
                string row = Console.ReadLine()!;
                for (int j = 0; j < C; j++) map[i, j] = row[j];
            }

            int rs = R - 1, re = 0, cs = C - 1, ce = 0;

            for (int i = 0; i < R; i++)
            {
                for (int j = 0; j < C; j++)
                {
                    if (map[i, j] == '.') continue;

                    int cnt = 0;
                    if (i - 1 < 0 || map[i - 1, j] == '.') cnt++;
                    if (i + 1 >= R || map[i + 1, j] == '.') cnt++;
                    if (j - 1 < 0 || map[i, j - 1] == '.') cnt++;
                    if (j + 1 >= C || map[i, j + 1] == '.') cnt++;

                    if (cnt >= 3) map[i, j] = 'o';

                    if (map[i, j] == 'X')
                    {
                        rs = Math.Min(rs, i);
                        re = Math.Max(re, i);
                        cs = Math.Min(cs, j);
                        ce = Math.Max(ce, j);
                    }
                }
            }

            for (int i = rs; i <= re; i++)
            {
                for (int j = cs; j <= ce; j++)
                    Console.Write(map[i, j] == 'X' ? 'X' : '.');
                Console.Write('\n');
            }
        }
    }
}
