namespace Algorithm.BOJ.BOJ_15652
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
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
        private static void CombinationWR(int[] arrN, int[] arrK, int s, int idx, StreamWriter sw)
        {
            if (idx == arrK.Length)
            {
                sw.WriteLine(string.Join(' ', arrK));
                return;
            }

            for (int i = s; i < arrN.Length; i++)
            {
                arrK[idx] = arrN[i];
                CombinationWR(arrN, arrK, i, idx + 1, sw);
            }
        }
    }
}
