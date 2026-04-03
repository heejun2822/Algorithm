namespace Algorithm.BOJ.BOJ_27223
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_27223/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            bool isPositive = n > 0;

            List<(int num, int cnt)> primeFactors = new();
            int temp = Math.Abs(n);

            // 소인수분해
            for (int i = 2; i * i <= temp; i++)
            {
                int cnt = 0;
                while (temp % i == 0)
                {
                    temp /= i;
                    cnt++;
                }
                if (cnt > 0)
                    primeFactors.Add((i, cnt));
            }
            if (temp > 1)
                primeFactors.Add((temp, 1));

            int[] negativeCnt = new int[primeFactors.Count];
            System.Text.StringBuilder output = new();

            BruteForceSearch(0, true);

            Console.Write(output);

            void BruteForceSearch(int idx, bool isCurrPositive)
            {
                if (idx == primeFactors.Count)
                {
                    if (isCurrPositive == isPositive)
                        WriteFactors();
                    return;
                }

                for (int i = 0; i <= primeFactors[idx].cnt; i++)
                {
                    negativeCnt[idx] = i;
                    BruteForceSearch(idx + 1, isCurrPositive);
                    isCurrPositive = !isCurrPositive;
                }
            }

            void WriteFactors()
            {
                for (int i = 0; i < primeFactors.Count; i++)
                {
                    for (int j = 0; j < primeFactors[i].cnt; j++)
                    {
                        if (j < negativeCnt[i])
                            output.Append('-');
                        output.Append(primeFactors[i].num).Append(' ');
                    }
                }
                output.AppendLine();
            }
        }
    }
}
