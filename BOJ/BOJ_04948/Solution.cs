namespace Algorithm.BOJ.BOJ_04948
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_04948/input.txt",
        ];

        public static void Run(string[] args)
        {
            List<int> inputs = new();
            while (true)
            {
                int n = int.Parse(Console.ReadLine()!);
                if (n == 0) break;
                inputs.Add(n);
            }
            int size = inputs.Max() * 2;
            bool[] isPrime = Enumerable.Repeat(true, size + 1).ToArray();
            isPrime[0] = isPrime[1] = false;
            int limit = (int)Math.Sqrt(size);
            for (int num = 2; num <= limit; num++)
            {
                if (!isPrime[num]) continue;
                for (int mul = 2 * num; mul <= size; mul += num) isPrime[mul] = false;
            }
            StringBuilder answer = new();
            foreach (int n in inputs)
            {
                int cnt = 0;
                for (int i = 2 * n; i > n; i--) if (isPrime[i]) cnt++;
                answer.AppendLine(cnt.ToString());
            }
            Console.WriteLine(answer);
        }
    }
}
