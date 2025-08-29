namespace Algorithm.BOJ.BOJ_15725
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15725/input.txt",
        ];

        public static void Run(string[] args)
        {
            string polynomial = Console.ReadLine()!;

            int s = 0;
            int e = polynomial.IndexOf('x');

            for (int i = e - 1; i >= 0; i--)
            {
                if (polynomial[i] == '+')
                {
                    s = i + 1;
                    break;
                }
                if (polynomial[i] == '-')
                {
                    s = i;
                    break;
                }
            }

            string differential = e == -1 ? "0" : polynomial[s..e];

            if (differential == "")
                differential = "1";
            else if (differential == "-")
                differential = "-1";

            Console.WriteLine(differential);
        }
    }
}
