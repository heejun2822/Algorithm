namespace Algorithm.BOJ.BOJ_01418
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01418/input1.txt",
            "BOJ/BOJ_01418/input2.txt",
            "BOJ/BOJ_01418/input3.txt",
            "BOJ/BOJ_01418/input4.txt",
            "BOJ/BOJ_01418/input5.txt",
        ];

        // 시간 초과
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

            int cnt = 0;

            for (int num = N; num > 0; num--)
            {
                for (int f = num; f > 0; f--)
                {
                    if (isPrimeNum[f] && num % f == 0)
                    {
                        if (f <= K) cnt++;
                        break;
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
