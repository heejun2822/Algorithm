namespace Algorithm.BOJ.BOJ_04673
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04673/input.txt",
        ];

        public static void Run(string[] args)
        {
            bool[] isSelfNumber = new bool[10001];
            Array.Fill(isSelfNumber, true);

            System.Text.StringBuilder output = new();

            for (int i = 1; i <= 10000; i++)
            {
                if (!isSelfNumber[i]) continue;

                output.AppendLine(i.ToString());

                int n = d(i);
                while (n <= 10000)
                {
                    isSelfNumber[n] = false;
                    n = d(n);
                }
            }

            Console.Write(output);

            int d(int n)
            {
                int res = n;
                while (n > 0)
                {
                    res += n % 10;
                    n /= 10;
                }
                return res;
            }
        }
    }
}
