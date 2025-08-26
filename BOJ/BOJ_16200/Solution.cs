namespace Algorithm.BOJ.BOJ_16200
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16200/input1.txt",
            "BOJ/BOJ_16200/input2.txt",
            "BOJ/BOJ_16200/input3.txt",
            "BOJ/BOJ_16200/input4.txt",
            "BOJ/BOJ_16200/input5.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] X = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            Array.Sort(X);

            int cnt = 0;
            int idx = 0;
            while (idx < N)
            {
                cnt++;
                idx += X[idx];
            }

            Console.WriteLine(cnt);
        }
    }
}
