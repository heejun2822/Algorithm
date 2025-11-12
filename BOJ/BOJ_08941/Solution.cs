namespace Algorithm.BOJ.BOJ_08941
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_08941/input.txt",
        ];

        public static void Run(string[] args)
        {
            Dictionary<char, double> weights = new() { { 'C', 12.01 }, { 'H', 1.008 }, { 'O', 16.00 }, { 'N', 14.01 } };

            int T = int.Parse(Console.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                string molecularFormula = Console.ReadLine()!;
                double molarMass = 0;

                int idx = 0;

                while (idx < molecularFormula.Length)
                {
                    double w = weights[molecularFormula[idx++]];
                    int cnt = 0;

                    while (idx < molecularFormula.Length && char.IsDigit(molecularFormula[idx]))
                        cnt = cnt * 10 + molecularFormula[idx++] - '0';

                    molarMass += w * (cnt > 0 ? cnt : 1);
                }

                Console.WriteLine(molarMass.ToString("F3"));
            }
        }
    }
}
