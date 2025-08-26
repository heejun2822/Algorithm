namespace Algorithm.BOJ.BOJ_11729
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11729/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int N = int.Parse(Console.ReadLine()!);
            sw.WriteLine((1 << N) - 1);
            MoveHanoiTower(N, 1, 2, 3, sw);

            sr.Close();
            sw.Close();
        }

        private static void MoveHanoiTower(int n, int s, int m, int e, StreamWriter sw)
        {
            if (n == 0) return;

            MoveHanoiTower(n - 1, s, e, m, sw);
            sw.Write(s);
            sw.Write(' ');
            sw.Write(e);
            sw.Write('\n');
            MoveHanoiTower(n - 1, m, s, e, sw);
        }
    }
}
