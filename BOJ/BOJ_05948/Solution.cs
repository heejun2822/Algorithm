namespace Algorithm.BOJ.BOJ_05948
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05948/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            bool[] appeared = new bool[10_000];
            int cnt = 0;

            while (!appeared[N])
            {
                appeared[N] = true;
                cnt++;

                int middle = N % 1000 / 10;
                N = middle * middle;
            }

            Console.WriteLine(cnt);
        }
    }
}
