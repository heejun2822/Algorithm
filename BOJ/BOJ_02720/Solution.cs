namespace Algorithm.BOJ.BOJ_02720
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02720/input.txt",
        ];

        public static void Run(string[] args)
        {
            int[] values = {25, 10, 5};
            StringBuilder answer = new();
            int T = int.Parse(Console.ReadLine()!);
            for (int _ = 0; _ < T; _++)
            {
                int C = int.Parse(Console.ReadLine()!);
                foreach (int value in values)
                {
                    answer.Append($"{C / value} ");
                    C %= value;
                }
                answer.Append($"{C}\n");
            }
            Console.WriteLine(answer);
        }
    }
}
