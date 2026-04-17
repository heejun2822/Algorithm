namespace Algorithm.BOJ.BOJ_06987
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06987/input.txt",
        ];

        public static void Run(string[] args)
        {
            List<(int country1, int country2)> matchs = new(15);

            for (int i = 0; i < 6; i++)
                for (int j = i + 1; j < 6; j++)
                    matchs.Add((i, j));

            (int w, int d, int l)[] results = new (int, int, int)[6];

            for (int _ = 0; _ < 4; _++)
            {
                string[] input = Console.ReadLine()!.Split();

                bool isValid = true;

                for (int i = 0; i < 6; i++)
                {
                    int w = int.Parse(input[3 * i]);
                    int d = int.Parse(input[3 * i + 1]);
                    int l = int.Parse(input[3 * i + 2]);
                    results[i] = (w, d, l);

                    if (w + d + l != 5)
                    {
                        isValid = false;
                        break;
                    }
                }

                isValid &= IsValidResult(0);

                Console.Write(isValid ? "1 " : "0 ");
            }
            Console.WriteLine();

            bool IsValidResult(int idx)
            {
                if (idx == 15)
                    return true;

                (int country1, int country2) = matchs[idx];

                if (results[country1].w > 0 && results[country2].l > 0)
                {
                    results[country1].w--;
                    results[country2].l--;
                    if (IsValidResult(idx + 1))
                        return true;
                    results[country1].w++;
                    results[country2].l++;
                }
                if (results[country1].d > 0 && results[country2].d > 0)
                {
                    results[country1].d--;
                    results[country2].d--;
                    if (IsValidResult(idx + 1))
                        return true;
                    results[country1].d++;
                    results[country2].d++;
                }
                if (results[country1].l > 0 && results[country2].w > 0)
                {
                    results[country1].l--;
                    results[country2].w--;
                    if (IsValidResult(idx + 1))
                        return true;
                    results[country1].l++;
                    results[country2].w++;
                }

                return false;
            }
        }
    }
}
