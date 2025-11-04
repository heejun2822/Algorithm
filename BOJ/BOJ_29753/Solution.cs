namespace Algorithm.BOJ.BOJ_29753
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_29753/input1.txt",
            "BOJ/BOJ_29753/input2.txt",
            "BOJ/BOJ_29753/input3.txt",
            "BOJ/BOJ_29753/input4.txt",
        ];

        public static void Run(string[] args)
        {
            (string grade, int rating)[] gradeList =
            {
                ("F", 0), ("D0", 100), ("D+", 150), ("C0", 200), ("C+", 250),
                ("B0", 300), ("B+", 350), ("A0", 400), ("A+", 450)
            };
            Dictionary<string, int> gradeMap = gradeList.ToDictionary(e => e.grade, e => e.rating);

            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int X = (int)MathF.Round(float.Parse(input[1]) * 100);

            int totalCredit = 0;
            int totalGrade = 0;

            for (int _ = 0; _ < N - 1; _++)
            {
                input = Console.ReadLine()!.Split();
                int c = int.Parse(input[0]);
                string g = input[1];

                totalCredit += c;
                totalGrade += c * gradeMap[g];
            }

            int L = int.Parse(Console.ReadLine()!);

            string output = "impossible";

            foreach ((string grade, int rating) in gradeList)
            {
                int gpa = (totalGrade + L * rating) / (totalCredit + L);
                if (gpa > X)
                {
                    output = grade;
                    break;
                }
            }

            Console.WriteLine(output);
        }
    }
}
