namespace Algorithm.BOJ.BOJ_05086
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_05086/input.txt",
        ];

        public static void Run(string[] args)
        {
            StringBuilder answer = new();
            while (true)
            {
                string[] numbers = Console.ReadLine()!.Split();
                if (numbers[0] == numbers[1]) break;
                int numA = int.Parse(numbers[0]);
                int numB = int.Parse(numbers[1]);
                if (numB % numA == 0) answer.AppendLine("factor");
                else if (numA % numB == 0) answer.AppendLine("multiple");
                else answer.AppendLine("neither");
            }
            Console.WriteLine(answer);
        }
    }
}
