namespace Algorithm.BOJ.BOJ_09184
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09184/input.txt",
        ];

        private static readonly int?[,,] Memo = new int?[20, 20, 20];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            while (true)
            {
                string[] input = sr.ReadLine()!.Split();
                int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]);
                if (a == -1 && b == -1 && c == -1) break;

                sw.WriteLine($"w({a}, {b}, {c}) = {W(a, b, c)}");
            }

            sr.Close();
            sw.Close();
        }

        private static int W(int a, int b, int c)
        {
            if (a <= 0 || b <= 0 || c <= 0) return 1;

            if (a > 20 || b > 20 || c > 20) return W(20, 20, 20);

            if (Memo[a - 1, b - 1, c - 1] == null)
                Memo[a - 1, b - 1, c - 1] = a < b && b < c
                    ? W(a, b, c - 1) + W(a, b - 1, c - 1) - W(a, b - 1, c)
                    : W(a - 1, b, c) + W(a - 1, b - 1, c) + W(a - 1, b, c - 1) - W(a - 1, b - 1, c - 1);
            return (int)Memo[a - 1, b - 1, c - 1]!;
        }
    }
}
