namespace Algorithm.BOJ.BOJ_02741
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02741/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder answer = new();
            for (int i = 1; i <= N; i++) answer.AppendLine(i.ToString());

            Console.Write(answer);
        }
    }
}
