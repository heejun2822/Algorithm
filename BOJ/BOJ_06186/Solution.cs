namespace Algorithm.BOJ.BOJ_06186
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06186/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] rc = Console.ReadLine()!.Split();
            int R = int.Parse(rc[0]);
            int C = int.Parse(rc[1]);

            int cnt = 0;

            string prevRow = new('.', C);
            string currRow;

            for (int _ = 0; _ < R; _++)
            {
                currRow = Console.ReadLine()!;
                for (int i = 0; i < C; i++)
                    if (currRow[i] == '#' && (i == 0 || currRow[i - 1] == '.') && prevRow[i] == '.') cnt++;
                prevRow = currRow;
            }

            Console.WriteLine(cnt);
        }
    }
}
