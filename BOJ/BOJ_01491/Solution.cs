namespace Algorithm.BOJ.BOJ_01491
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01491/input1.txt",
            "BOJ/BOJ_01491/input2.txt",
            "BOJ/BOJ_01491/input3.txt",
            "BOJ/BOJ_01491/input4.txt",
            "BOJ/BOJ_01491/input5.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            int itr = Math.Min(N, M);
            Console.Write(itr % 2 == 1 ? N - 1 - itr / 2 : itr / 2 - 1);
            Console.Write(" ");
            Console.Write(itr % 2 == 1 ? M - 1 - itr / 2 : itr / 2);
            Console.Write("\n");
        }
    }
}
