namespace Algorithm.BOJ.BOJ_04773
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04773/input.txt",
        ];

        public static void Run(string[] args)
        {
            Dictionary<char, int> RomanNumerals = new()
            {
                {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
                {'C', 100}, {'D', 500}, {'M', 1000}
            };
            List<(int num, string roman)> RomanUnits = new()
            {
                (1000, "M"),
                (900, "CM"), (500, "D"), (400, "CD"), (100, "C"),
                (90, "XC"), (50, "L"), (40, "XL"), (10, "X"),
                (9, "IX"), (5, "V"), (4, "IV"), (1, "I")
            };

            Stack<int> stack = new();
            string input;

            while ((input = Console.ReadLine()!) != null)
            {
                if (input == "=")
                {
                    if (stack.Count < 1)
                    {
                        Console.WriteLine("stack underflow");
                        continue;
                    }
                    int num = stack.Peek();
                    if (num <= 0 || num > 4999)
                    {
                        Console.WriteLine("out of range exception");
                        continue;
                    }
                    Console.WriteLine(NumberToRoman(num));
                }
                else if (input == "+")
                {
                    if (stack.Count < 2)
                    {
                        Console.WriteLine("stack underflow");
                        continue;
                    }
                    int b = stack.Pop(), a = stack.Pop();
                    stack.Push(a + b);
                }
                else if (input == "-")
                {
                    if (stack.Count < 2)
                    {
                        Console.WriteLine("stack underflow");
                        continue;
                    }
                    int b = stack.Pop(), a = stack.Pop();
                    stack.Push(a - b);
                }
                else if (input == "*")
                {
                    if (stack.Count < 2)
                    {
                        Console.WriteLine("stack underflow");
                        continue;
                    }
                    int b = stack.Pop(), a = stack.Pop();
                    stack.Push(a * b);
                }
                else if (input == "/")
                {
                    if (stack.Count < 2)
                    {
                        Console.WriteLine("stack underflow");
                        continue;
                    }
                    int b = stack.Pop();
                    if (b == 0)
                    {
                        Console.WriteLine("division by zero exception");
                        continue;
                    }
                    int a = stack.Pop();
                    stack.Push(a / b);
                }
                else
                {
                    stack.Push(RomanToNumber(input));
                }
            }

            int RomanToNumber(string roman)
            {
                int num = RomanNumerals[roman[^1]];
                for (int i = roman.Length - 2; i >= 0; i--)
                {
                    if (RomanNumerals[roman[i]] < RomanNumerals[roman[i + 1]])
                        num -= RomanNumerals[roman[i]];
                    else
                        num += RomanNumerals[roman[i]];
                }
                return num;
            }

            string NumberToRoman(int num)
            {
                string roman = "";
                foreach (var unit in RomanUnits)
                {
                    if (num == 0) break;
                    while (num >= unit.num)
                    {
                        roman += unit.roman;
                        num -= unit.num;
                    }
                }
                return roman;
            }
        }
    }
}
