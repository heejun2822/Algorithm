namespace Algorithm.BOJ.BOJ_01434
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01434/input1.txt",
            "BOJ/BOJ_01434/input2.txt",
            "BOJ/BOJ_01434/input3.txt",
            "BOJ/BOJ_01434/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int[] B = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int capacity = 0;
            for (int i = 0; i < N; i++) capacity += A[i];
            for (int i = 0; i < M; i++) capacity -= B[i];

            Console.WriteLine(capacity);
        }
    }
}
