namespace Algorithm.BOJ.BOJ_14608
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14608/input.txt",
        ];

        public static void Run(string[] args)
        {
            int K = int.Parse(Console.ReadLine()!);  // K = 1
            int[] c = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            string[] abn = Console.ReadLine()!.Split();
            int a = int.Parse(abn[0]);
            int b = int.Parse(abn[1]);
            int N = int.Parse(abn[2]);

            Console.WriteLine(0.5f * (b - a) / N);
        }
    }
}
