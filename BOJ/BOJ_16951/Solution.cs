namespace Algorithm.BOJ.BOJ_16951
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16951/input1.txt",
            "BOJ/BOJ_16951/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] input = sr.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            int[] A = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

            bool[] visited = new bool[N];
            int maxCnt = 0;

            for (int i = 0; i < N; i++)
            {
                if (visited[i]) continue;

                visited[i] = true;

                if (A[i] < 1 + K * i) continue;

                int cnt = 1;
                int height = A[i];

                for (int j = i + 1; j < N; j++)
                {
                    height += K;

                    if (!visited[j] && A[j] == height)
                    {
                        visited[j] = true;
                        cnt++;
                    }
                }

                maxCnt = Math.Max(maxCnt, cnt);
            }

            sw.WriteLine(N - maxCnt);

            sr.Close();
            sw.Close();
        }
    }
}
