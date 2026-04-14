namespace Algorithm.BOJ.BOJ_34479
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_34479/input1.txt",
            "BOJ/BOJ_34479/input2.txt",
            "BOJ/BOJ_34479/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] orders =
            {
                "NESW", "NEWS", "NSEW", "NSWE", "NWES", "NWSE",
                "ENSW", "ENWS", "ESNW", "ESWN", "EWNS", "EWSN",
                "SNEW", "SNWE", "SENW", "SEWN", "SWNE", "SWEN",
                "WNES", "WNSE", "WENS", "WESN", "WSNE", "WSEN"
            };
            Dictionary<char, int> dr = new() { {'N', -1}, {'E', 0}, {'S', 1}, {'W', 0} };
            Dictionary<char, int> dc = new() { {'N', 0}, {'E', 1}, {'S', 0}, {'W', -1} };

            string[] input = Console.ReadLine()!.Split();
            int r = int.Parse(input[0]), c = int.Parse(input[1]);

            bool[,] isFlat = new bool[r, c];
            int posR = 0, posC = 0;

            for (int i = 0; i < r; i++)
            {
                string row = Console.ReadLine()!;
                for (int j = 0; j < c; j++)
                {
                    if (row[j] == '.')
                        isFlat[i, j] = true;
                    else if (row[j] == 'S')
                    {
                        isFlat[i, j] = true;
                        posR = i;
                        posC = j;
                    }
                }
            }

            string s = Console.ReadLine()!;

            int minCnt = 0;
            int[] prevDP = new int[24];
            int[] currDP = new int[24];

            foreach (char move in s)
            {
                int newMinCnt = 10000;

                for (int k = 0; k < 24; k++)
                {
                    currDP[k] = -1;

                    if (IsValidOrder(move, orders[k]))
                    {
                        currDP[k] = prevDP[k] != -1 ? prevDP[k] : minCnt + 1;
                        newMinCnt = Math.Min(newMinCnt, currDP[k]);
                    }
                }

                minCnt = newMinCnt;
                (prevDP, currDP) = (currDP, prevDP);
                posR += dr[move];
                posC += dc[move];
            }

            Console.WriteLine(minCnt);

            bool IsValidOrder(char move, string order)
            {
                foreach (char dir in order)
                {
                    int nextR = posR + dr[dir], nextC = posC + dc[dir];
                    if (nextR >= 0 && nextR < r && nextC >= 0 && nextC < c && isFlat[nextR, nextC])
                        return dir == move;
                }
                return false;
            }
        }
    }
}
