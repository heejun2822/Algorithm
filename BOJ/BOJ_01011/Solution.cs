namespace Algorithm.BOJ.BOJ_01011
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01011/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder output = new();

            while (T-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);

                double d = y - x;
                int n = (int)Math.Sqrt(d);
                int cnt = 2 * n - 1 + (int)Math.Ceiling((d - n * n) / n);

                output.AppendLine(cnt.ToString());
            }

            Console.Write(output);
        }
    }
}
