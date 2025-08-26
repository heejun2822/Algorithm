namespace Algorithm.BOJ.BOJ_25308
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25308/input1.txt",
            "BOJ/BOJ_25308/input2.txt",
        ];

        private static int[] a = new int[8];
        private static (float x, float y)[] directions = new (float, float)[8];
        private static (float x, float y)[] vertices = new (float, float)[8];
        private static bool[] visited = new bool[8];

        public static void Run(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                a[i] = ReadInt();
                directions[i] = (MathF.Cos(MathF.PI / 4 * (2 - i)), MathF.Sin(MathF.PI / 4 * (2 - i)));
            }

            vertices[0] = (directions[0].x * a[0], directions[0].y * a[0]);
            visited[0] = true;

            int cnt = 0;
            Permutate(1, ref cnt);

            Console.WriteLine(cnt * 8);
        }

        private static void Permutate(int idx, ref int cnt)
        {
            if (idx == 8)
            {
                if (IsClockwise(6, 7, 0) && IsClockwise(7, 0, 1)) cnt++;
                return;
            }

            for (int i = 1; i < 8; i++)
            {
                if (visited[i]) continue;

                vertices[idx] = (directions[idx].x * a[i], directions[idx].y * a[i]);

                if (idx >= 2 && !IsClockwise(idx - 2, idx - 1, idx)) continue;

                visited[i] = true;
                Permutate(idx + 1, ref cnt);
                visited[i] = false;
            }
        }

        private static bool IsClockwise(int v1, int v2, int v3)
        {
            (float x, float y) edge1 = (vertices[v2].x - vertices[v1].x, vertices[v2].y - vertices[v1].y);
            (float x, float y) edge2 = (vertices[v3].x - vertices[v2].x, vertices[v3].y - vertices[v2].y);

            return edge1.x * edge2.y - edge1.y * edge2.x <= 0;
        }

        private static int ReadInt()
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = Console.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { Console.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}
