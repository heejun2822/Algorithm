namespace Algorithm.BOJ.BOJ_01418
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01418/input1.txt",
            "BOJ/BOJ_01418/input2.txt",
            "BOJ/BOJ_01418/input3.txt",
            "BOJ/BOJ_01418/input4.txt",
            "BOJ/BOJ_01418/input5.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int K = int.Parse(Console.ReadLine()!);

            bool[] isPrimeNum = new bool[N + 1];
            Array.Fill(isPrimeNum, true);

            int lim = (int)Math.Sqrt(N);

            for (int i = 2; i <= lim; i++)
                if (isPrimeNum[i])
                    for (int j = i * 2; j <= N; j += i)
                        isPrimeNum[j] = false;

            List<int> primeNumbers = new(lim);

            for (int i = N; i > 0; i--)
                if (isPrimeNum[i])
                    primeNumbers.Add(i);

            int sIdx = 0;
            int cnt = 0;

            for (int num = N; num > 0; num--)
            {
                if (primeNumbers[sIdx] > num)
                    sIdx++;

                for (int i = sIdx; i < primeNumbers.Count; i++)
                {
                    int pf = primeNumbers[i];
                    if (num % pf == 0)
                    {
                        if (pf <= K) cnt++;
                        break;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
