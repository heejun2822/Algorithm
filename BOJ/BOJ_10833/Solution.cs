namespace Algorithm.BOJ.BOJ_10833
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10833/input1.txt",
            "BOJ/BOJ_10833/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int cnt = 0;

            while (N-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                int studentCnt = int.Parse(input[0]);
                int appleCnt = int.Parse(input[1]);
                cnt += appleCnt % studentCnt;
            }

            Console.WriteLine(cnt);
        }
    }
}
