namespace Algorithm.BOJ.BOJ_001546
{
    public class Solution : SolutionBOJ
    {
        protected override string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_001546/input1.txt",
            "BOJ/BOJ_001546/input2.txt",
            "BOJ/BOJ_001546/input3.txt",
            "BOJ/BOJ_001546/input4.txt",
            "BOJ/BOJ_001546/input5.txt",
            "BOJ/BOJ_001546/input6.txt",
            "BOJ/BOJ_001546/input7.txt",
            "BOJ/BOJ_001546/input8.txt",
        ];

        public override void Run()
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] scores = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int M = scores.Max();
            float avg = (float)scores.Average() / M * 100;
            Console.WriteLine(avg);
        }
    }
}
