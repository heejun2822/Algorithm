namespace Algorithm.BOJ.BOJ_25206
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25206/input1.txt",
            "BOJ/BOJ_25206/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int totalUnit = 0;
            float score = 0;
            for (int i = 0; i < 20; i++)
            {
                string[] info = Console.ReadLine()!.Split();
                if (info[2] == "P") continue;
                int unit = info[1][0] - '0';
                float grade = 0;
                switch (info[2])
                {
                    case "A+": grade = 4.5f; break;
                    case "A0": grade = 4.0f; break;
                    case "B+": grade = 3.5f; break;
                    case "B0": grade = 3.0f; break;
                    case "C+": grade = 2.5f; break;
                    case "C0": grade = 2.0f; break;
                    case "D+": grade = 1.5f; break;
                    case "D0": grade = 1.0f; break;
                    default: break;
                }
                totalUnit += unit;
                score += grade * unit;
            }
            Console.WriteLine(score / totalUnit);
        }
    }
}
