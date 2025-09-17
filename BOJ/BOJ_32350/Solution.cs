namespace Algorithm.BOJ.BOJ_32350
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_32350/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int D = int.Parse(input[1]);
            int p = int.Parse(input[2]);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int turn = 0;

            for (int i = 0; i < N; i++)
            {
                if (A[i] <= 0) continue;

                while (A[i] > 0)
                {
                    A[i] -= D;
                    turn++;
                }

                if (A[i] < 0 && i + 1 < N)
                {
                    A[i + 1] -= -A[i] * p / 100;
                }
            }

            Console.WriteLine(turn);
        }
    }
}
