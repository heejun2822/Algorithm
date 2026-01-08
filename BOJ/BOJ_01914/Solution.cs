namespace Algorithm.BOJ.BOJ_01914
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01914/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            System.Numerics.BigInteger K = System.Numerics.BigInteger.Pow(2, N) - 1;
            System.Text.StringBuilder procedure = new();

            Console.WriteLine(K);

            if (N <= 20)
            {
                Hanoi(N, 1, 3, 2);
                Console.Write(procedure);
            }

            void Hanoi(int cnt, int from, int to, int tmp)
            {
                if (cnt == 0) return;

                Hanoi(cnt - 1, from, tmp, to);
                procedure.AppendLine($"{from} {to}");
                Hanoi(cnt - 1, tmp, to, from);
            }
        }
    }
}
