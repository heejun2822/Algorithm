namespace Algorithm.BOJ.BOJ_27960
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_27960/input1.txt",
            "BOJ/BOJ_27960/input2.txt",
            "BOJ/BOJ_27960/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] scores = Console.ReadLine()!.Split();
            int S_A = int.Parse(scores[0]);
            int S_B = int.Parse(scores[1]);
            Console.WriteLine(S_A ^ S_B);
        }
    }
}
