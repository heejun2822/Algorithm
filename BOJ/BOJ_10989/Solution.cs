namespace Algorithm.BOJ.BOJ_10989
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10989/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());
            int N = int.Parse(sr.ReadLine()!);
            // 카운팅 정렬 (Counting Sort)
            int[] countingArr = new int[10001];
            for (int _ = 0; _ < N; _++)
            {
                int num = int.Parse(sr.ReadLine()!);
                countingArr[num]++;
            }
            for (int num = 1; num < 10001; num++)
            {
                for (int _ = 0; _ < countingArr[num]; _++)
                {
                    sw.WriteLine(num);
                }
            }
            sr.Close();
            sw.Close();
        }
    }
}
