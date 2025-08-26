namespace Algorithm.BOJ.BOJ_01546
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01546/input1.txt",
            "BOJ/BOJ_01546/input2.txt",
            "BOJ/BOJ_01546/input3.txt",
            "BOJ/BOJ_01546/input4.txt",
            "BOJ/BOJ_01546/input5.txt",
            "BOJ/BOJ_01546/input6.txt",
            "BOJ/BOJ_01546/input7.txt",
            "BOJ/BOJ_01546/input8.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] scores = Console.ReadLine()!.Split().Select(int.Parse).ToArray();
            int M = scores.Max();
            float avg = (float)scores.Average() / M * 100;
            Console.WriteLine(avg);
        }
    }
}
