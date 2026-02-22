namespace Algorithm.BOJ.BOJ_01351
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01351/input1.txt",
            "BOJ/BOJ_01351/input2.txt",
            "BOJ/BOJ_01351/input3.txt",
            "BOJ/BOJ_01351/input4.txt",
            "BOJ/BOJ_01351/input5.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            long N = long.Parse(input[0]);
            int P = int.Parse(input[1]);
            int Q = int.Parse(input[2]);

            Dictionary<long, long> A = new() { {0, 1} };

            Console.WriteLine(GetA(N));

            long GetA(long idx)
            {
                if (!A.ContainsKey(idx))
                    A[idx] = GetA(idx / P) + GetA(idx / Q);

                return A[idx];
            }
        }
    }
}
