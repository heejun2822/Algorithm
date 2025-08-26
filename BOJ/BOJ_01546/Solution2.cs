namespace Algorithm.BOJ.BOJ_01546
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
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
            string[] scores = Console.ReadLine()!.Split();
            float sum = 0;
            int M = 0;
            for (int i = 0; i < N; i++)
            {
                int score = int.Parse(scores[i]);
                sum += score;
                if (score > M) M = score;
            }
            float avg = sum / N / M * 100;
            Console.WriteLine(avg);
        }
    }
}
