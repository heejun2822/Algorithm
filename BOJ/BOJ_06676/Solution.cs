namespace Algorithm.BOJ.BOJ_06676
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06676/input.txt",
        ];

        public static void Run(string[] args)
        {
            Dictionary<string, (int number, int method)> wordList = new()
            {
                { "negative", (-1, 0) },
                { "zero", (0, 1) }, { "one", (1, 1) }, { "two", (2, 1) }, { "three", (3, 1) }, { "four", (4, 1) },
                { "five", (5, 1) }, { "six", (6, 1) }, { "seven", (7, 1) }, { "eight", (8, 1) }, { "nine", (9, 1) },
                { "ten", (10, 1) }, { "eleven", (11, 1) }, { "twelve", (12, 1) }, { "thirteen", (13, 1) }, { "fourteen", (14, 1) },
                { "fifteen", (15, 1) }, { "sixteen", (16, 1) }, { "seventeen", (17, 1) }, { "eighteen", (18, 1) }, { "nineteen", (19, 1) },
                { "twenty", (20, 1) }, { "thirty", (30, 1) }, { "forty", (40, 1) }, { "fifty", (50, 1) },
                { "sixty", (60, 1) }, { "seventy", (70, 1) }, { "eighty", (80, 1) }, { "ninety", (90, 1) },
                { "hundred", (100, 2) },
                { "thousand", (1000, 3) }, { "million", (1000000, 3) }
            };

            System.Text.StringBuilder output = new();

            while (true)
            {
                string input = Console.ReadLine()!;

                if (input == null || input == "") break;

                int sign = 1;
                int value = 0;
                int tempValue = 0;

                foreach (string word in input.Split())
                {
                    (int number, int method) = wordList[word];

                    switch (method)
                    {
                        case 0:
                            sign = number;
                            break;
                        case 1:
                            tempValue += number;
                            break;
                        case 2:
                            tempValue *= number;
                            break;
                        case 3:
                            value += tempValue * number;
                            tempValue = 0;
                            break;
                        default:
                            break;
                    }
                }

                value += tempValue;
                value *= sign;

                output.AppendLine(value.ToString());
            }

            Console.Write(output);
        }
    }
}
