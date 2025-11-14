namespace Algorithm.BOJ.BOJ_16034
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16034/input.txt",
        ];

        public static void Run(string[] args)
        {
            int b;
            System.Text.StringBuilder output = new();

            while ((b = int.Parse(Console.ReadLine()!)) != 0)
            {
                int n = (int)((Math.Sqrt(8L * b + 1) - 1) / 2);  // n(n+1)/2 <= b
                int sum = n * (n + 1) / 2;

                while ((b - sum) % n != 0)
                    sum -= n--;

                output.Append((b - sum) / n + 1).Append(' ').Append(n).Append('\n');
            }

            Console.Write(output);
        }
    }
}
