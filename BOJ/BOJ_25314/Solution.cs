namespace Algorithm.BOJ.BOJ_25314
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25314/input1.txt",
            "BOJ/BOJ_25314/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string answer = "int";
            for (int i = 0; i < N / 4; i++)
            {
                answer = "long " + answer;
            }
            Console.WriteLine(answer);
        }
    }
}
