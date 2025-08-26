namespace Algorithm.BOJ.BOJ_15652
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15652/input1.txt",
            "BOJ/BOJ_15652/input2.txt",
            "BOJ/BOJ_15652/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            string[] nm = sr.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            int[] arrN = Enumerable.Range(1, N).ToArray();
            int[] arrK = new int[M];
            CombinationWR(arrN, arrK, 0, 0, sw);

            sr.Close();
            sw.Close();
        }

        // 중복조합 (Combination with Repetition)
        private static void CombinationWR(int[] arrN, int[] arrK, int idxN, int idxK, StreamWriter sw)
        {
            if (idxK == arrK.Length)
            {
                sw.WriteLine(string.Join(' ', arrK));
                return;
            }

            if (idxN == arrN.Length) return;

            arrK[idxK] = arrN[idxN];
            CombinationWR(arrN, arrK, idxN, idxK + 1, sw);
            CombinationWR(arrN, arrK, idxN + 1, idxK, sw);
        }
    }
}
