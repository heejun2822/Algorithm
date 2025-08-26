namespace Algorithm.BOJ.BOJ_11462
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11462/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            while (int.TryParse(sr.ReadLine()!, out int N))
            {
                int num = N, p = 1;

                while (num % 10 == 0)
                {
                    num /= 10;
                    p *= 10;
                }

                sw.WriteLine(N - p);
            }

            sr.Close();
            sw.Close();
        }
    }
}
