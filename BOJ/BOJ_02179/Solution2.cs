namespace Algorithm.BOJ.BOJ_02179
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02179/input1.txt",
            "BOJ/BOJ_02179/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);
            (string word, int idx)[] arr = new (string, int)[N];

            for (int i = 0; i < N; i++)
                arr[i] = (sr.ReadLine()!, i);

            Array.Sort(arr);

            int maxLen = -1;
            List<(string word, int idx)> list = new();

            for (int i = 1; i < N; i++)
            {
                (string word, int idx) A = arr[i - 1];
                (string word, int idx) B = arr[i];

                int len = 0;
                int idx = 0;

                while (idx < A.word.Length && idx < B.word.Length)
                {
                    if (A.word[idx] != B.word[idx]) break;
                    len++;
                    idx++;
                }

                if (len > maxLen)
                {
                    maxLen = len;
                    list.Clear();
                    list.Add(A);
                    list.Add(B);
                }
                else if (len == maxLen)
                {
                    if (A != list[^1])
                        list.Add(A);
                    list.Add(B);
                }
            }

            list.Sort((a, b) => a.idx - b.idx);

            string S = list[0].word;
            string T = "";
            string prefix = S[..maxLen];

            for (int i = 1; i < N; i++)
            {
                if (list[i].word.StartsWith(prefix))
                {
                    T = list[i].word;
                    break;
                }
            }

            sw.WriteLine(S);
            sw.WriteLine(T);

            sr.Close();
            sw.Close();
        }
    }
}
