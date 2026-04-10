namespace Algorithm.BOJ.BOJ_30805
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30805/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            int M = int.Parse(Console.ReadLine()!);
            int[] B = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int[] lowerLimits = new int[101];
            List<int> CSS = new();

            for (int i = 0; i < N; i++)
            {
                for (int j = lowerLimits[A[i]]; j < M; j++)
                {
                    if (A[i] == B[j])
                    {
                        while (CSS.Count > 0 && CSS[^1] < A[i])
                            CSS.RemoveAt(CSS.Count - 1);

                        CSS.Add(A[i]);

                        for (int k = 1; k <= A[i]; k++)
                            lowerLimits[k] = j + 1;

                        break;
                    }
                }
            }

            int K = CSS.Count;
            Console.WriteLine(K);
            if (K != 0)
                Console.WriteLine(string.Join(' ', CSS));
        }
    }
}
