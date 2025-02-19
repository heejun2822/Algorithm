namespace Algorithm.BOJ.BOJ_01644
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01644/input1.txt",
            "BOJ/BOJ_01644/input2.txt",
            "BOJ/BOJ_01644/input3.txt",
            "BOJ/BOJ_01644/input4.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            bool[] isNotPrime = new bool[N + 1];

            int lim = (int)Math.Sqrt(N);
            for (int i = 2; i <= lim; i++)
                if (!isNotPrime[i])
                    for (int j = i * 2; j <= N; j += i)
                        isNotPrime[j] = true;

            int num = 1;
            Queue<int> sumedPrimes = new();
            int sum = 0;
            int cnt = 0;

            while (true)
            {
                if (sum == N) cnt++;

                if (sum < N)
                {
                    while (++num <= N && isNotPrime[num]);

                    if (num > N) break;

                    sumedPrimes.Enqueue(num);
                    sum += num;
                }
                else
                {
                    sum -= sumedPrimes.Dequeue();
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
