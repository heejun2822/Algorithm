namespace Algorithm.BOJ.BOJ_16431
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16431/input1.txt",
            "BOJ/BOJ_16431/input2.txt",
            "BOJ/BOJ_16431/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] B = Console.ReadLine()!.Split();
            string[] D = Console.ReadLine()!.Split();
            string[] J = Console.ReadLine()!.Split();

            int Br = int.Parse(B[0]), Bc = int.Parse(B[1]);
            int Dr = int.Parse(D[0]), Dc = int.Parse(D[1]);
            int Jr = int.Parse(J[0]), Jc = int.Parse(J[1]);

            int bessie = Math.Max(Math.Abs(Br - Jr), Math.Abs(Bc - Jc));
            int daisy = Math.Abs(Dr - Jr) + Math.Abs(Dc - Jc);

            string faster = "tie";
            if (bessie < daisy) faster = "bessie";
            else if (daisy < bessie) faster = "daisy";

            Console.WriteLine(faster);
        }
    }
}
