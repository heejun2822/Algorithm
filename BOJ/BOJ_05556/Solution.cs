namespace Algorithm.BOJ.BOJ_05556
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_05556/input1.txt",
            "BOJ/BOJ_05556/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int K = int.Parse(Console.ReadLine()!);
            StringBuilder answer = new();
            for (int _ = 0; _ < K; _++)
            {
                string[] pos = Console.ReadLine()!.Split();
                int a = int.Parse(pos[0]);
                int b = int.Parse(pos[1]);
                int c = Math.Min(Math.Min(a, N + 1 - a), Math.Min(b, N + 1 - b));
                answer.AppendLine(((c - 1) % 3 + 1).ToString());
            }
            Console.WriteLine(answer);
        }
    }
}
