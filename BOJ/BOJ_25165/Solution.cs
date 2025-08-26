namespace Algorithm.BOJ.BOJ_25165
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25165/input1.txt",
            "BOJ/BOJ_25165/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]), M = int.Parse(nm[1]);
            string[] ad = Console.ReadLine()!.Split();
            int Ac = int.Parse(ad[0]), D = int.Parse(ad[1]);
            string[] ss = Console.ReadLine()!.Split();
            int Sr = int.Parse(ss[0]), Sc = int.Parse(ss[1]);

            if (Sr == N && ((D == 0 && N % 2 == 1) || (D == 1 && N % 2 == 0)))
                Console.WriteLine("YES!");
            else
                Console.WriteLine("NO...");
        }
    }
}
