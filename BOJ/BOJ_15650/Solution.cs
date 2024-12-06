namespace Algorithm.BOJ.BOJ_15650
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15650/input1.txt",
            "BOJ/BOJ_15650/input2.txt",
            "BOJ/BOJ_15650/input3.txt",
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
            Combination(arrN, arrK, 0, 0, sw);

            sr.Close();
            sw.Close();
        }

        // 조합 (Combination)
        private static void Combination(int[] arrN, int[] arrK, int s, int idx, StreamWriter sw)
        {
            if (idx == arrK.Length)
            {
                sw.WriteLine(string.Join(' ', arrK));
                return;
            }

            int e = arrN.Length - (arrK.Length - idx);
            for (int i = s; i <= e; i++)
            {
                arrK[idx] = arrN[i];
                Combination(arrN, arrK, i + 1, idx + 1, sw);
            }
        }
    }
}
