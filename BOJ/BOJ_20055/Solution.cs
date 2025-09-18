namespace Algorithm.BOJ.BOJ_20055
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20055/input1.txt",
            "BOJ/BOJ_20055/input2.txt",
            "BOJ/BOJ_20055/input3.txt",
            "BOJ/BOJ_20055/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int N2 = 2 * N;

            int putIdx = 0;
            int landIdx = N - 1;
            bool[] hasRobot = new bool[N2];
            int brokenCnt = 0;

            int steps = 0;

            while (brokenCnt < K)
            {
                steps++;

                putIdx = (putIdx - 1 + N2) % N2;
                landIdx = (landIdx - 1 + N2) % N2;

                hasRobot[landIdx] = false;

                for (int i = 1; i < N - 1; i++)
                {
                    int idx = (landIdx - i + N2) % N2;
                    if (!hasRobot[idx]) continue;
                    int nextIdx = (idx + 1) % N2;
                    if (!hasRobot[nextIdx] && A[nextIdx] > 0)
                    {
                        hasRobot[nextIdx] = true;
                        hasRobot[idx] = false;
                        if (--A[nextIdx] == 0)
                            brokenCnt++;
                    }
                }

                hasRobot[landIdx] = false;

                if (A[putIdx] > 0)
                {
                    hasRobot[putIdx] = true;
                    if (--A[putIdx] == 0)
                        brokenCnt++;
                }
            }

            Console.WriteLine(steps);
        }
    }
}
