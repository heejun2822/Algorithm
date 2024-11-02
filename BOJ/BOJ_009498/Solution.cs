namespace Algorithm.BOJ.BOJ_009498
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_009498/input.txt",
        ];

        public override void Run()
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
