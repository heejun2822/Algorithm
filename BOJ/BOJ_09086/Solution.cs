namespace Algorithm.BOJ.BOJ_09086
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09086/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            System.Text.StringBuilder answer = new();
            for (int i = 0; i < T; i++)
            {
                string str = Console.ReadLine()!;
                answer.AppendLine($"{str[0]}{str[^1]}");
            }
            Console.WriteLine(answer);
        }
    }
}
