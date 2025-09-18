namespace Algorithm.BOJ.BOJ_20437
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20437/input1.txt",
            "BOJ/BOJ_20437/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder output = new();

            while (T-- > 0)
            {
                string W = Console.ReadLine()!;
                int K = int.Parse(Console.ReadLine()!);

                Queue<int>[] queueArr = new Queue<int>[26];
                for (int i = 0; i < 26; i++)
                    queueArr[i] = new(K);

                int minLen = 10000;
                int maxLen = 0;

                for (int i = 0; i < W.Length; i++)
                {
                    int c = W[i] - 'a';
                    if (queueArr[c].Count == K)
                    {
                        queueArr[c].Dequeue();
                    }
                    queueArr[c].Enqueue(i);
                    if (queueArr[c].Count == K)
                    {
                        int len = i - queueArr[c].Peek() + 1;
                        minLen = Math.Min(minLen, len);
                        maxLen = Math.Max(maxLen, len);
                    }
                }

                output.AppendLine(maxLen == 0 ? "-1" : $"{minLen} {maxLen}");
            }

            Console.Write(output);
        }
    }
}
