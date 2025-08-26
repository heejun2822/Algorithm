namespace Algorithm.BOJ.BOJ_30456
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30456/input1.txt",
            "BOJ/BOJ_30456/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nl = Console.ReadLine()!.Split();
            int N = int.Parse(nl[0]);
            int L = int.Parse(nl[1]);

            string P = new string('1', L - 1) + N.ToString();

            Console.WriteLine(P);
        }
    }
}
