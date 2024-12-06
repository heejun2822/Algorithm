namespace Algorithm.BOJ.BOJ_15649
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15649/input1.txt",
            "BOJ/BOJ_15649/input2.txt",
            "BOJ/BOJ_15649/input3.txt",
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
            bool[] visited = new bool[N];
            int[] arrK = new int[M];
            Permutation(arrN, visited, arrK, 0, sw);

            sr.Close();
            sw.Close();
        }

        // 순열 (Permutation)
        private static void Permutation(int[] arrN, bool[] visited, int[] arrK, int idx, StreamWriter sw)
        {
            if (idx == arrK.Length)
            {
                sw.WriteLine(string.Join(' ', arrK));
                return;
            }

            for (int i = 0; i < arrN.Length; i++)
            {
                if (visited[i]) continue;
                arrK[idx] = arrN[i];
                visited[i] = true;
                Permutation(arrN, visited, arrK, idx + 1, sw);
                visited[i] = false;
            }
        }
    }
}
