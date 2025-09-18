namespace Algorithm.BOJ.BOJ_09655
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09655/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            bool[] win = new bool[N + 1];
            win[1] = true;
            if (N >= 3) win[3] = true;

            for (int i = 4; i <= N; i++)
                win[i] = !win[i - 1] || !win[i - 3];

            Console.WriteLine(win[N] ? "SK" : "CY");
        }
    }
}
