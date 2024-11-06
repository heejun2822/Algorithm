namespace Algorithm.BOJ.BOJ_10952
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10952/input.txt",
        ];

        public static void Run(string[] args)
        {
            System.Text.StringBuilder answer = new();
            while (true)
            {
                string[] numbers = Console.ReadLine()!.Split();
                int A = int.Parse(numbers[0]);
                int B = int.Parse(numbers[1]);
                if (A == 0 && B == 0) break;
                answer.AppendLine((A + B).ToString());
            }
            Console.WriteLine(answer);
        }
    }
}
