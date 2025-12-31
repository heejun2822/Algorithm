namespace Algorithm.BOJ.BOJ_14686
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14686/input1.txt",
            "BOJ/BOJ_14686/input2.txt",
            "BOJ/BOJ_14686/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = ReadInt();

            int[] accScoreSwifts = new int[N + 1];

            for (int i = 1; i <= N; i++)
                accScoreSwifts[i] = accScoreSwifts[i - 1] + ReadInt();

            int accScoreSemaphores = 0;
            int K = 0;

            for (int i = 1; i <= N; i++)
                if ((accScoreSemaphores += ReadInt()) == accScoreSwifts[i])
                    K = i;

            Console.WriteLine(K);
        }

        private static int ReadInt()
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = Console.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { Console.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
