namespace Algorithm.BOJ.BOJ_05211
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05211/input1.txt",
            "BOJ/BOJ_05211/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] score = Console.ReadLine()!.Split('|');
            char[] C_Majors = {'C', 'F', 'G'};
            char[] A_Minors = {'A', 'D', 'E'};
            int cntC = 0;
            int cntA = 0;
            for (int i = 0; i < score.Length; i++)
            {
                char note = score[i][0];
                if (C_Majors.Contains(note)) cntC++;
                else if (A_Minors.Contains(note)) cntA++;
            }
            string scale;
            if (cntC > cntA) scale = "C-major";
            else if (cntC < cntA) scale = "A-minor";
            else scale = C_Majors.Contains(score[^1][^1]) ? "C-major" : "A-minor";
            Console.WriteLine(scale);
        }
    }
}
