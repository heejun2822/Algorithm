namespace Algorithm.BOJ.BOJ_03496
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_03496/input.txt",
        ];

        public static void Run(string[] args)
        {
            int m = int.Parse(Console.ReadLine()!);

            int n = (int)Math.Ceiling(Math.Log2(m));
            int p = (int)Math.Pow(2, n);
            int u = p - m;

            System.Text.StringBuilder output = new();

            for (int i = 0; i < u; i++)
                output.AppendLine(Convert.ToString(i, 2).PadLeft(n - 1, '0'));

            for (int i = p - (m - u); i < p; i++)
                output.AppendLine(Convert.ToString(i, 2).PadLeft(n, '0'));

            Console.Write(output);
        }
    }
}
