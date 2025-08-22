namespace Algorithm.PRO.PRO_12929 // 올바른 괄호의 갯수
{
    class Solution
    {
        private static Solution Instance { get; } = new();

        public static string[] InputPaths { get; private set; } =
        [
            "PRO/PRO_12929/input1.txt",
            "PRO/PRO_12929/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int n = System.Text.Json.JsonSerializer.Deserialize<int>(Console.ReadLine()!);

            Console.WriteLine(Instance.solution(n));
        }

        public int solution(int n)
        {
            int answer = 0;
            DFS(n, 1, 0, ref answer);

            return answer;
        }

        private void DFS(int n, int openedCnt, int closedCnt, ref int answer)
        {
            if (openedCnt == n)
            {
                answer++;
                return;
            }

            for (int i = openedCnt - closedCnt; i >= 0; i--)
                DFS(n, openedCnt + 1, closedCnt + i, ref answer);
        }
    }
}
