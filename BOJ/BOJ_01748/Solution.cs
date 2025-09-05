namespace Algorithm.BOJ.BOJ_01748
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01748/input1.txt",
            "BOJ/BOJ_01748/input2.txt",
            "BOJ/BOJ_01748/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int cnt = 0;
            int l = 1, h = 9, p = 1;

            while (N >= l)
            {
                cnt += (Math.Min(h, N) - l + 1) * p;
                l *= 10;
                h = h * 10 + 9;
                p++;
            }

            Console.WriteLine(cnt);
        }
    }
}
