namespace Algorithm.BOJ.BOJ_13238
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13238/input1.txt",
            "BOJ/BOJ_13238/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine()!);
            int[] exchangeRates = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            int minExchangeRate = 10000;
            int maxBenefit = 0;

            foreach (int rate in exchangeRates)
            {
                if (rate <= minExchangeRate) minExchangeRate = rate;
                else maxBenefit = Math.Max(maxBenefit, rate - minExchangeRate);
            }

            sw.WriteLine(maxBenefit);

            sr.Close();
            sw.Close();
        }
    }
}
