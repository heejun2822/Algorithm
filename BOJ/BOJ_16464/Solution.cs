namespace Algorithm.BOJ.BOJ_16464
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16464/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder output = new();

            for (int _ = 0; _ < N; _++)
            {
                int K = int.Parse(Console.ReadLine()!);

                int cnt = 1;
                int sum = 1;
                bool win = false;

                while ((sum += ++cnt) <= K)
                {
                    if ((K - sum) % cnt == 0)
                    {
                        win = true;
                        break;
                    }
                }

                output.AppendLine(win ? "Gazua" : "GoHanGang");
            }

            Console.Write(output);
        }
    }
}
