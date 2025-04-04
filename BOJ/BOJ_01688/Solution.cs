namespace Algorithm.BOJ.BOJ_01688
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01688/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            (int x, int y)[] vertices = new (int, int)[N];
            for (int i = 0; i < N; i++) vertices[i] = (ReadInt(sr), ReadInt(sr));

            for (int _ = 0; _ < 3; _++)
            {
                int x = ReadInt(sr), y = ReadInt(sr);
                bool isSafe = false;

                for (int i = 0; i < N; i++)
                {
                    (int lx1, int ly1) = vertices[i];
                    (int lx2, int ly2) = vertices[(i + 1) % N];

                    if (IsOnLine(lx1, ly1, lx2, ly2, x, y))
                    {
                        isSafe = true;
                        break;
                    }
                    // 주어진 범위 내에서 가능한 최소 절댓값의 기울기(0보다는 큰)보다 더 작은 절댓값의 기울기가 되도록 선분의 끝점을 설정하면
                    // 그 선분은 다각형의 모든 꼭짓점과 만나지 않고 다각형의 모든 변과 평행하지 않도록 할 수 있다.
                    if (IsIntersected(lx1, ly1, lx2, ly2, x, y, 2_000_000_000, y + 1))
                        isSafe = !isSafe;
                }

                sw.WriteLine(isSafe ? "1" : "0");
            }

            sr.Close();
            sw.Close();
        }

        private static bool IsOnLine(int lx1, int ly1, int lx2, int ly2, int x, int y)
        {
            if (lx1 == lx2)
            {
                return y >= Math.Min(ly1, ly2) && y <= Math.Max(ly1, ly2) && x == lx1;
            }
            else
            {
                double a = Math.Abs(x - lx1);
                double b = Math.Abs(x - lx2);
                return x >= Math.Min(lx1, lx2) && x <= Math.Max(lx1, lx2) && y == (a * ly2 + b * ly1) / (a + b);
            }
        }

        private static bool IsIntersected(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            return CCW(x1, y1, x2, y2, x3, y3) * CCW(x1, y1, x2, y2, x4, y4) <= 0 && CCW(x3, y3, x4, y4, x1, y1) * CCW(x3, y3, x4, y4, x2, y2) <= 0;
        }

        private static int CCW(long x1, long y1, long x2, long y2, long x3, long y3)
        {
            long cp = (x2 - x1) * (y3 - y2) - (y2 - y1) * (x3 - x2);
            return cp > 0 ? 1 : cp < 0 ? -1 : 0;
        }

        private static int ReadInt(StreamReader sr)
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { sr.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
