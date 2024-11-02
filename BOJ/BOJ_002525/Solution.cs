namespace Algorithm.BOJ.BOJ_002525
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_002525/input1.txt",
            "BOJ/BOJ_002525/input2.txt",
            "BOJ/BOJ_002525/input3.txt",
        ];

        public override void Run()
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
