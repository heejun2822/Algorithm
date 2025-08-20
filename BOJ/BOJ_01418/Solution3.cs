namespace Algorithm.BOJ.BOJ_01418
{
    public class Solution3
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

            bool[] visited = new bool[N + 1];
            int cnt = 0;

            for (int i = 2; i <= N; i++)
            {
                if (!isPrimeNum[i]) continue;

                if (i <= K)
                {
                    for (int j = i * 2; j <= N; j += i)
                    {
                        isPrimeNum[j] = false;
                    }
                }
                else
                {
                    visited[i] = true;
                    cnt++;

                    for (int j = i * 2; j <= N; j += i)
                    {
                        isPrimeNum[j] = false;

                        if (!visited[j])
                        {
                            visited[j] = true;
                            cnt++;
                        }
                    }
                }
            }

            Console.WriteLine(N - cnt);
        }
    }
}
