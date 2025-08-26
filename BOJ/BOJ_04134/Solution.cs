namespace Algorithm.BOJ.BOJ_04134
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04134/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            StringBuilder answer = new();
            for (int _ = 0; _ < T; _++)
            {
                uint n = uint.Parse(Console.ReadLine()!);
                uint num = n;
                while (true)
                {
                    if (IsPrimeNumber(num)) break;
                    num++;
                }
                answer.AppendLine(num.ToString());
            }
            Console.WriteLine(answer);
        }

        private static bool IsPrimeNumber(uint num)
        {
            if (num < 2) return false;
            uint limit = (uint)Math.Sqrt(num);
            for (uint i = 2; i <= limit; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
    }
}
