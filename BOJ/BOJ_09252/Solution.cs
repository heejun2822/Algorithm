namespace Algorithm.BOJ.BOJ_09252
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09252/input.txt",
        ];

        public static void Run(string[] args)
        {
            string str1 = Console.ReadLine()!;
            string str2 = Console.ReadLine()!;

            Memo?[,] memos = new Memo?[str1.Length + 1, str2.Length + 1];

            for (int i = 1; i <= str1.Length; i++)
            {
                for (int j = 1; j <= str2.Length; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                        memos[i, j] = new(str1[i - 1], memos[i - 1, j - 1]);
                    else
                        memos[i, j] = (memos[i - 1, j]?.len ?? 0) > (memos[i, j - 1]?.len ?? 0) ? memos[i - 1, j] : memos[i, j - 1];
                }
            }

            Stack<char> stack = new();
            Memo? memo = memos[str1.Length, str2.Length];
            while (memo != null)
            {
                stack.Push(memo.c);
                memo = memo.prevMemo;
            }

            StringBuilder LCS = new();
            while (stack.Count > 0) LCS.Append(stack.Pop());

            Console.WriteLine(LCS.Length);
            if (LCS.Length == 0) return;
            Console.WriteLine(LCS);
        }

        private class Memo
        {
            public readonly char c;
            public readonly Memo? prevMemo;
            public readonly int len;

            public Memo(char c, Memo? prevMemo)
            {
                this.c = c;
                this.prevMemo = prevMemo;
                this.len = (prevMemo?.len ?? 0) + 1;
            }
        }
    }
}
