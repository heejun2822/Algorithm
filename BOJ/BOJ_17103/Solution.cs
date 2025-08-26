namespace Algorithm.BOJ.BOJ_17103
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17103/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            int[] inputs = new int[T];
            for (int i = 0; i < T; i++) inputs[i] = int.Parse(Console.ReadLine()!);
            int size = inputs.Max();
            bool[] isPrime = Enumerable.Repeat(true, size + 1).ToArray();
            isPrime[0] = isPrime[1] = false;
            int limit = (int)Math.Sqrt(size);
            for (int num = 2; num <= limit; num++)
            {
                if (!isPrime[num]) continue;
                for (int mul = 2 * num; mul <= size; mul += num) isPrime[mul] = false;
            }
            StringBuilder answer = new();
            foreach (int N in inputs)
            {
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
