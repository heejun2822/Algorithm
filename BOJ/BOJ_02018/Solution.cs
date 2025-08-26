namespace Algorithm.BOJ.BOJ_02018
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02018/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int cnt = 0;
            int num = 0, sum = 0;
            while ((sum += ++num) <= N)
                if ((N - sum) % num == 0) cnt++;

            Console.WriteLine(cnt);
        }
    }
}
