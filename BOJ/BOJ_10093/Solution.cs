namespace Algorithm.BOJ.BOJ_10093
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10093/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] numbers = Console.ReadLine()!.Split();
            long A = long.Parse(numbers[0]);
            long B = long.Parse(numbers[1]);
            if (A > B) (A, B) = (B, A);
            StringBuilder answer = new();
            answer.AppendLine(Math.Max(B - A - 1, 0).ToString());
            for (long i = A + 1; i < B; i++) answer.Append($"{i} ");
            Console.WriteLine(answer);
        }
    }
}
