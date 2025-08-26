namespace Algorithm.BOJ.BOJ_02753
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02753/input1.txt",
            "BOJ/BOJ_02753/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int year = int.Parse(Console.ReadLine()!);
            int answer = 0;
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) answer = 1;
            Console.WriteLine(answer);
        }
    }
}
