namespace Algorithm.BOJ.BOJ_25288
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_25288/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string str = Console.ReadLine()!;

            System.Text.StringBuilder answer = new();
            for (int _ = 0; _ < N; _++) answer.Append(str);

            Console.WriteLine(answer);
        }
    }
}
