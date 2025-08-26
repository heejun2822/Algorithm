namespace Algorithm.BOJ.BOJ_15815
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15815/input.txt",
        ];

        public static void Run(string[] args)
        {
            Stack<int> numbers = new();

            while (true)
            {
                int c = Console.Read();

                if (c == '+')
                {
                    int b = numbers.Pop(), a = numbers.Pop();
                    numbers.Push(a + b);
                }
                else if (c == '-')
                {
                    int b = numbers.Pop(), a = numbers.Pop();
                    numbers.Push(a - b);
                }
                else if (c == '*')
                {
                    int b = numbers.Pop(), a = numbers.Pop();
                    numbers.Push(a * b);
                }
                else if (c == '/')
                {
                    int b = numbers.Pop(), a = numbers.Pop();
                    numbers.Push(a / b);
                }
                else if (c >= '0' && c <= '9')
                {
                    numbers.Push(c - '0');
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(numbers.Pop());
        }
    }
}
