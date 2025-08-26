namespace Algorithm.BOJ.BOJ_02884
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02884/input1.txt",
            "BOJ/BOJ_02884/input2.txt",
            "BOJ/BOJ_02884/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] time = Console.ReadLine()!.Split();
            int H = int.Parse(time[0]);
            int M = int.Parse(time[1]);
            if (M >= 45) Console.WriteLine($"{H} {M - 45}");
            else if (H > 0) Console.WriteLine($"{H - 1} {M + 15}");
            else Console.WriteLine($"23 {M + 15}");
        }
    }
}
