namespace Algorithm.BOJ.BOJ_03015
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_03015/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            Stack<(int h, long cnt)> stack = new();
            long pairCnt = 0;

            for (int _ = 0; _ < N; _++)
            {
                int h = int.Parse(Console.ReadLine()!);
                long cnt = 1;

                while (stack.TryPeek(out (int h, long cnt) se) && se.h <= h)
                {
                    stack.Pop();
                    pairCnt += se.cnt;
                    if (se.h == h) cnt += se.cnt;
                }

                if (stack.Count > 0)
                    pairCnt++;

                stack.Push((h, cnt));
            }

            Console.WriteLine(pairCnt);
        }
    }
}
