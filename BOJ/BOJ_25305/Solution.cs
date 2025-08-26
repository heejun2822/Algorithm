namespace Algorithm.BOJ.BOJ_25305
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25305/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] Nk = Console.ReadLine()!.Split();
            int N = int.Parse(Nk[0]);
            int k = int.Parse(Nk[1]);
            int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            Array.Sort(arr);
            Console.WriteLine(arr[N - k]);
        }
    }
}
