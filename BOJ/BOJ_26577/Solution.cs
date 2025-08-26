namespace Algorithm.BOJ.BOJ_26577
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_26577/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            for (int _ = 0; _ < n; _++)
            {
                string[] equation = Console.ReadLine()!.Split();

                int[] integers = new int[equation.Length / 2 + 1];
                integers[0] = int.Parse(equation[0]);
                char[] operators = new char[equation.Length / 2];
                int idx = 0;

                for (int i = 0; i < equation.Length / 2; i++)
                {
                    char op = char.Parse(equation[2 * i + 1]);
                    int num = int.Parse(equation[2 * i + 2]);

                    if (op == '+' || op == '-')
                    {
                        operators[idx++] = op;
                        integers[idx] = num;
                    }
                    else if (op == '*')
                        integers[idx] *= num;
                    else if (op == '/')
                        integers[idx] /= num;
                    else if (op == '%')
                        integers[idx] %= num;
                }

                for (int i = 0; i < idx; i++)
                {
                    if (operators[i] =='+')
                        integers[0] += integers[i + 1];
                    else if (operators[i] == '-')
                        integers[0] -= integers[i + 1];
                }

                Console.WriteLine(integers[0]);
            }
        }
    }
}
