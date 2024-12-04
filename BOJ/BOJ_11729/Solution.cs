namespace Algorithm.BOJ.BOJ_11729
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
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

            int ts = n % 2 == 1 ? m : e;
            int tm = s;
            int te = n % 2 == 1 ? e : m;
            for (int i = 1; i <= n; i++)
            {
                sw.WriteLine($"{s} {te}");
                MoveHanoiTower(i - 1, ts, tm, te, sw);
                (ts, te) = (te, ts);
            }
        }
    }
}
