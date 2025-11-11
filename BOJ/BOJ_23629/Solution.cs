namespace Algorithm.BOJ.BOJ_23629
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_23629/input1.txt",
            "BOJ/BOJ_23629/input2.txt",
            "BOJ/BOJ_23629/input3.txt",
            "BOJ/BOJ_23629/input4.txt",
            "BOJ/BOJ_23629/input5.txt",
        ];

        public static void Run(string[] args)
        {
            string[] digitWords = { "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE" };

            string S = Console.ReadLine()!;

            bool isMad = false;
            System.Text.StringBuilder formula = new();
            long answer = 0;

            char opr = '+';
            long number = 0;
            int idx = 0;

            while (idx < S.Length)
            {
                if (IsOperator(S[idx]))
                {
                    if (number == 0)
                    {
                        isMad = true;
                        break;
                    }

                    if (opr == '+')
                        answer += number;
                    else if (opr == '-')
                        answer -= number;
                    else if (opr == 'x')
                        answer *= number;
                    else if (opr == '/')
                        answer /= number;

                    opr = S[idx];
                    number = 0;
                    idx++;
                    formula.Append(opr);
                }
                else
                {
                    int digit = -1;

                    for (int i = 0; i < 10; i++)
                    {
                        if (IsMatch(digitWords[i]))
                        {
                            digit = i;
                            break;
                        }
                    }

                    if (digit == -1)
                    {
                        isMad = true;
                        break;
                    }

                    number = number * 10 + digit;
                    idx += digitWords[digit].Length;
                    formula.Append(digit);
                }
            }

            if (isMad)
            {
                Console.WriteLine("Madness!");
            }
            else
            {
                formula.AppendLine();
                if (answer < 0)
                    formula.Append('-');
                foreach (char d in Math.Abs(answer).ToString())
                    formula.Append(digitWords[d - '0']);

                Console.WriteLine(formula);
            }

            bool IsOperator(char c)
            {
                return c == '+' || c == '-' || c == 'x' || c == '/' || c == '=';
            }

            bool IsMatch(string word)
            {
                if (idx + word.Length > S.Length)
                    return false;

                for (int i = 0; i < word.Length; i++)
                    if (word[i] != S[idx + i])
                        return false;

                return true;
            }
        }
    }
}
