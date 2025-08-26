namespace Algorithm.BOJ.BOJ_09417
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09417/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int N = int.Parse(sr.ReadLine()!);
            for (int _ = 0; _ < N; _++)
            {
                int[] numbers = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);
                Array.Sort(numbers);

                int max = 1;
                for (int i = numbers.Length - 2; i >= 0; i--)
                {
                    if (numbers[i] <= max) break;
                    for (int j = numbers.Length - 1; j > i; j--)
                        max = Math.Max(max, GCD(numbers[j], numbers[i]));
                }

                sw.WriteLine(max);
            }

            sr.Close();
            sw.Close();
        }

        private static int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }
    }
}
