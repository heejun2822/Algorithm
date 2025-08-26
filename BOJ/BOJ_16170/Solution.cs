namespace Algorithm.BOJ.BOJ_16170
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16170/input.txt",
        ];

        public static void Run(string[] args)
        {
            DateTime utcNow = DateTime.UtcNow;
            Console.WriteLine(utcNow.Year.ToString("D4"));
            Console.WriteLine(utcNow.Month.ToString("D2"));
            Console.WriteLine(utcNow.Day.ToString("D2"));
        }
    }
}
