namespace Algorithm.BOJ.BOJ_17103
{
    using System.Text;

    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17103/input.txt",
        ];

        public static void Run(string[] args)
        {
            int size = 1000000;
            bool[] isPrime = new bool[size + 1];
            Array.Fill(isPrime, true, 2, isPrime.Length - 2);
            for (int num = 2; num <= 1000; num++) // Math.Sqrt(size)
            {
                if (!isPrime[num]) continue;
                for (int mul = 2 * num; mul <= size; mul += num) isPrime[mul] = false;
            }
            int T = int.Parse(Console.ReadLine()!);
            StringBuilder answer = new();
            for (int _ = 0; _ < T; _++)
            {
                int N = int.Parse(Console.ReadLine()!);
                int cnt = 0;
                for (int i = 2; i <= N / 2; i++)
                {
                    if (isPrime[i] && isPrime[N - i]) cnt++;
                }
                answer.AppendLine(cnt.ToString());
            }
            Console.WriteLine(answer);
        }
    }
}
