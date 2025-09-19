namespace Algorithm.BOJ.BOJ_07490
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_07490/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder output = new();

            while (T-- > 0)
            {
                int N = int.Parse(Console.ReadLine()!);

                List<string> formulas = new();
                MakeFormula(0, 1, 1, new char[N - 1], formulas);

                foreach (string formula in formulas)
                    output.AppendLine(formula);
                output.AppendLine();
            }

            Console.Write(output);

            void MakeFormula(int idx, int prevNum, int result, char[] operators, List<string> formulas)
            {
                if (idx == operators.Length)
                {
                    if (result == 0)
                    {
                        System.Text.StringBuilder formula = new("1");
                        for (int i = 0; i < operators.Length; i++)
                            formula.Append(operators[i]).Append(i + 2);
                        formulas.Add(formula.ToString());
                    }
                    return;
                }

                int num = idx + 2;

                operators[idx] = ' ';
                int newPrevNum = prevNum * 10 + (prevNum > 0 ? num : -num);
                MakeFormula(idx + 1, newPrevNum, result - prevNum + newPrevNum, operators, formulas);

                operators[idx] = '+';
                MakeFormula(idx + 1, num, result + num, operators, formulas);

                operators[idx] = '-';
                MakeFormula(idx + 1, -num, result - num, operators, formulas);
            }
        }
    }
}
