namespace Algorithm.BOJ.BOJ_15651
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15651/input1.txt",
            "BOJ/BOJ_15651/input2.txt",
            "BOJ/BOJ_15651/input3.txt",
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
            PermutationWR(arrN, arrK, 0, sw);

            sr.Close();
            sw.Close();
        }

        // 중복순열 (Permutation with Repetition)
        private static void PermutationWR(int[] arrN, int[] arrK, int idx, StreamWriter sw)
        {
            if (idx == arrK.Length)
            {
                sw.WriteLine(string.Join(' ', arrK));
                return;
            }

            for (int i = 0; i < arrN.Length; i++)
            {
                arrK[idx] = arrN[i];
                PermutationWR(arrN, arrK, idx + 1, sw);
            }
        }
    }
}
