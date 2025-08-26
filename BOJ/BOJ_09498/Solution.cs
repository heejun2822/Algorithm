namespace Algorithm.BOJ.BOJ_09498
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09498/input.txt",
        ];

        public static void Run(string[] args)
        {
            int score = int.Parse(Console.ReadLine()!);
            string grade;
            if (score >= 90) grade = "A";
            else if (score >= 80) grade = "B";
            else if (score >= 70) grade = "C";
            else if (score >= 60) grade = "D";
            else grade = "F";
            Console.WriteLine(grade);
        }
    }
}
