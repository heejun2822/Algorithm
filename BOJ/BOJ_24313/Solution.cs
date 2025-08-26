namespace Algorithm.BOJ.BOJ_24313
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_24313/input1.txt",
            "BOJ/BOJ_24313/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] a = Console.ReadLine()!.Split();
            int a1 = int.Parse(a[0]);
            int a0 = int.Parse(a[1]);
            int c = int.Parse(Console.ReadLine()!);
            int n0 = int.Parse(Console.ReadLine()!);
            string answer = a1 <= c && a1 * n0 + a0 <= c * n0 ? "1" : "0";
            Console.WriteLine(answer);
        }
    }
}
