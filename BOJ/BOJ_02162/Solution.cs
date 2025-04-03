namespace Algorithm.BOJ.BOJ_02162
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02162/input1.txt",
            "BOJ/BOJ_02162/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            Line[] lines = new Line[N];
            GroupManager groupManager = new(N);

            for (int i = 0; i < N; i++)
            {
                lines[i] = new Line() { x1 = ReadInt(sr), y1 = ReadInt(sr), x2 = ReadInt(sr), y2 = ReadInt(sr) };

                for (int j = 0; j < i; j++)
                    if (lines[i].IntersectsWith(lines[j])) groupManager.Union(j, i);
            }

            sw.WriteLine(groupManager.GroupCount);
            sw.WriteLine(groupManager.MaxGroupSize);

            sr.Close();
            sw.Close();
        }

        private class Line
        {
            public int x1;
            public int y1;
            public int x2;
            public int y2;

            public bool IntersectsWith(Line line)
            {
                int ccw1 = CCW(x1, y1, x2, y2, line.x1, line.y1);
                int ccw2 = CCW(x1, y1, x2, y2, line.x2, line.y2);
                int ccw3 = CCW(line.x1, line.y1, line.x2, line.y2, x1, y1);
                int ccw4 = CCW(line.x1, line.y1, line.x2, line.y2, x2, y2);

                if (ccw1 == 0 && ccw2 == 0)
                {
                    if (x1 == x2)
                        return Math.Min(line.y1, line.y2) <= Math.Max(y1, y2) && Math.Max(line.y1, line.y2) >= Math.Min(y1, y2);
                    return Math.Min(line.x1, line.x2) <= Math.Max(x1, x2) && Math.Max(line.x1, line.x2) >= Math.Min(x1, x2);
                }
                return ccw1 * ccw2 <= 0 && ccw3 * ccw4 <= 0;
            }

            private static int CCW(int x1, int y1, int x2, int y2, int x3, int y3)
            {
                int cp = (x2 - x1) * (y3 - y2) - (y2 - y1) * (x3 - x2);
                return cp > 0 ? 1 : cp < 0 ? -1 : 0;
            }
        }

        private class GroupManager
        {
            private int[] groups;
            public int GroupCount { get; private set; }
            public int MaxGroupSize { get; private set; }

            public GroupManager(int N)
            {
                groups = new int[N];
                Array.Fill(groups, -1);
                GroupCount = N;
                MaxGroupSize = 1;
            }

            public void Union(int a, int b)
            {
                a = Find(a);
                b = Find(b);

                if (a == b) return;

                if (groups[a] <= groups[b])
                {
                    groups[a] += groups[b];
                    groups[b] = a;
                    MaxGroupSize = Math.Max(MaxGroupSize, -groups[a]);
                }
                else
                {
                    groups[b] += groups[a];
                    groups[a] = b;
                    MaxGroupSize = Math.Max(MaxGroupSize, -groups[b]);
                }
                GroupCount--;
            }

            private int Find(int a)
            {
                return groups[a] < 0 ? a : (groups[a] = Find(groups[a]));
            }
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
