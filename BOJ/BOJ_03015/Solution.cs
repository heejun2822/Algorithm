namespace Algorithm.BOJ.BOJ_03015
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_03015/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            Stack<(int h, long cnt)> stack = new();
            (int h, long cnt) se;
            long pairCnt = 0;

            for (int _ = 0; _ < N; _++)
            {
                int h = int.Parse(Console.ReadLine()!);

                while (stack.TryPeek(out se) && se.h < h)
                {
                    long cnt = stack.Pop().cnt;
                    pairCnt += cnt * (cnt - 1) / 2;
                    pairCnt += cnt * (stack.Count > 0 ? 2 : 1);
                }

                if (stack.TryPeek(out se) && se.h == h)
                {
                    stack.Pop();
                    stack.Push((se.h, se.cnt + 1));
                }
                else
                    stack.Push((h, 1));
            }

            while (stack.Count > 0)
            {
                long cnt = stack.Pop().cnt;
                pairCnt += cnt * (cnt - 1) / 2;
                pairCnt += cnt * (stack.Count > 0 ? 1 : 0);
            }

            Console.WriteLine(pairCnt);
        }
    }
}
