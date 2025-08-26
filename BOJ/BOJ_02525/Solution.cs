namespace Algorithm.BOJ.BOJ_02525
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02525/input1.txt",
            "BOJ/BOJ_02525/input2.txt",
            "BOJ/BOJ_02525/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] currentTime = Console.ReadLine()!.Split();
            int A = int.Parse(currentTime[0]);
            int B = int.Parse(currentTime[1]);
            int C = int.Parse(Console.ReadLine()!);
            int h = (A + (B + C) / 60) % 24;
            int m = (B + C) % 60;
            Console.WriteLine($"{h} {m}");
        }
    }
}
