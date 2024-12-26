namespace Algorithm.BOJ.BOJ_11399
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11399/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] P = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            Array.Sort(P);

            int sum = 0;
            for (int i = 0; i < N; i++) sum += P[i] * (N - i);

            Console.WriteLine(sum);
        }
    }
}
