namespace Algorithm.BOJ.BOJ_02138
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02138/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            string currState = Console.ReadLine()!;
            string goalState = Console.ReadLine()!;

            char[] stateA = new char[N];
            char[] stateB = new char[N];

            for (int i = 0; i < N; i++)
                stateA[i] = stateB[i] = currState[i];

            int cntA = 0;
            int cntB = 0;

            ToggleSwitch(stateB, ref cntB, 0);

            for (int i = 1; i < N; i++)
            {
                if (stateA[i - 1] != goalState[i - 1])
                    ToggleSwitch(stateA, ref cntA, i);
                if (stateB[i - 1] != goalState[i - 1])
                    ToggleSwitch(stateB, ref cntB, i);
            }

            int minCnt = int.MaxValue;

            if (stateA[^1] == goalState[^1])
                minCnt = Math.Min(minCnt, cntA);
            if (stateB[^1] == goalState[^1])
                minCnt = Math.Min(minCnt, cntB);

            Console.WriteLine(minCnt == int.MaxValue ? -1 : minCnt);

            void ToggleSwitch(char[] state, ref int cnt, int idx)
            {
                int s = idx - 1, e = idx + 1;
                if (idx == 0) s++;
                if (idx == N - 1) e--;

                for (int i = s; i <= e; i++)
                    state[i] = state[i] == '0' ? '1' : '0';

                cnt++;
            }
        }
    }
}
