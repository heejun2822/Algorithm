namespace Algorithm.BOJ.BOJ_07286
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_07286/input.txt",
        ];

        public static void Run(string[] args)
        {
            int[] timeline = new int[1001];
            StringBuilder answer = new();

            int t = int.Parse(Console.ReadLine()!);
            for (int _ = 0; _ < t; _++)
            {
                Array.Clear(timeline);
                int n = int.Parse(Console.ReadLine()!);
                for (int i = 0; i < n; i++)
                {
                    string[] info = Console.ReadLine()!.Split();
                    int a = int.Parse(info[1]), b = int.Parse(info[2]);
                    timeline[a]++;
                    timeline[b]--;
                }

                int cnt = 0;
                for (int i = 0; i <= 1000; i++)
                {
                    cnt += timeline[i];
                    if (cnt > 0) answer.Append((char)('A' - 1 + cnt));
                }
                answer.Append('\n');
            }

            Console.WriteLine(answer);
        }
    }
}
