namespace Algorithm.BOJ.BOJ_33156
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_33156/input1.txt",
            "BOJ/BOJ_33156/input2.txt",
        ];

        public static void Run(string[] args)
        {
            const bool LEFT = false, RIGHT = true;
            const bool POP = false, PUSH = true;

            int N = int.Parse(Console.ReadLine()!);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Dictionary<int, int> counts = new();
            int diff = 0;

            for (int i = 0; i < N; i++)
            {
                if (i <= (N - 1) / 2)
                {
                    if (!counts.TryAdd(A[i], 1))
                        counts[A[i]]++;
                }
                else
                {
                    if (!counts.TryAdd(A[i], -1))
                        counts[A[i]]--;
                }
            }
            foreach (KeyValuePair<int, int> ele in counts)
                diff += Math.Abs(ele.Value);

            int l = 0, r = N - 1;

            if (N % 2 == 1)
                ManipulateSequence(A[l++], LEFT, POP);

            while (r - l + 1 > 0)
            {
                if (l == 0)
                {
                    while (true)
                    {
                        if (diff == 0) break;
                        if (r == N - 1) break;

                        ManipulateSequence(A[l++], LEFT, POP);
                        ManipulateSequence(A[++r], RIGHT, PUSH);
                        ManipulateSequence(A[(l + r) / 2], RIGHT, POP);
                        ManipulateSequence(A[(l + r) / 2], LEFT, PUSH);
                    }
                }
                else if (r == N - 1)
                {
                    while (true)
                    {
                        if (diff == 0) break;
                        if (l == 0) break;

                        ManipulateSequence(A[r--], RIGHT, POP);
                        ManipulateSequence(A[--l], LEFT, PUSH);
                        ManipulateSequence(A[(l + r) / 2 + 1], LEFT, POP);
                        ManipulateSequence(A[(l + r) / 2 + 1], RIGHT, PUSH);
                    }
                }

                if (diff == 0) break;

                if (l == 0)
                {
                    ManipulateSequence(A[r--], RIGHT, POP);
                    ManipulateSequence(A[r--], RIGHT, POP);
                    ManipulateSequence(A[(l + r) / 2 + 1], LEFT, POP);
                    ManipulateSequence(A[(l + r) / 2 + 1], RIGHT, PUSH);
                }
                else if (r == N - 1)
                {
                    ManipulateSequence(A[l++], LEFT, POP);
                    ManipulateSequence(A[l++], LEFT, POP);
                    ManipulateSequence(A[(l + r) / 2], RIGHT, POP);
                    ManipulateSequence(A[(l + r) / 2], LEFT, PUSH);
                }
            }

            Console.WriteLine(r - l + 1);

            void ManipulateSequence(int num, bool isRight, bool isPush)
            {
                diff -= Math.Abs(counts[num]);
                if (isRight ^ isPush)
                    counts[num]++;
                else
                    counts[num]--;
                diff += Math.Abs(counts[num]);
            }
        }
    }
}
