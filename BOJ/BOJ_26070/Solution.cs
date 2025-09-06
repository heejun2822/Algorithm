namespace Algorithm.BOJ.BOJ_26070
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_26070/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int A = int.Parse(input[0]), B = int.Parse(input[1]), C = int.Parse(input[2]);
            input = Console.ReadLine()!.Split();
            int X = int.Parse(input[0]), Y = int.Parse(input[1]), Z = int.Parse(input[2]);

            long cnt = 0;

            for (int _ = 0; _ < 3; _++)
            {
                int chickenCnt = Math.Min(A, X);
                A -= chickenCnt;
                X -= chickenCnt;
                int pizzaCnt = Math.Min(B, Y);
                B -= pizzaCnt;
                Y -= pizzaCnt;
                int hamburgerCnt = Math.Min(C, Z);
                C -= hamburgerCnt;
                Z -= hamburgerCnt;

                cnt = cnt + chickenCnt + pizzaCnt + hamburgerCnt;
                (X, Y, Z) = (X % 3 + Z / 3, Y % 3 + X / 3, Z % 3 + Y / 3);
            }

            Console.WriteLine(cnt);
        }
    }
}
