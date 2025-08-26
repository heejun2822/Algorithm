namespace Algorithm.BOJ.BOJ_01629
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01629/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int A = int.Parse(input[0]), B = int.Parse(input[1]), C = int.Parse(input[2]);

            Console.WriteLine(Power(A, B, C));
        }

        private static long Power(long A, long B, long C)
        {
            if (B == 1) return A % C;

            if (B % 2 == 1) return A * Power(A, B - 1, C) % C;

            long powered = Power(A, B / 2, C);
            return powered * powered % C;
        }
    }
}
