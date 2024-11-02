namespace Algorithm.BOJ.BOJ_002884
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_002884/input1.txt",
            "BOJ/BOJ_002884/input2.txt",
            "BOJ/BOJ_002884/input3.txt",
        ];

        public override void Run()
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
