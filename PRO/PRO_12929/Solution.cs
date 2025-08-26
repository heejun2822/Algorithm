namespace Algorithm.PRO.PRO_12929 // 올바른 괄호의 갯수
{
    public class Solution : SolutionPRO<Solution>, ISolutionPRO
    {
        public static string[] InputPaths { get; set; } =
        [
            "PRO/PRO_12929/input1.txt",
            "PRO/PRO_12929/input2.txt",
        ];

        public override void Run(string[] args)
        {
            int n = System.Text.Json.JsonSerializer.Deserialize<int>(Console.ReadLine()!);

            int answer = solution(n);

            Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(answer));
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
