namespace Algorithm.BOJ.BOJ_02618
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02618/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);
            int W = int.Parse(sr.ReadLine()!);

            Pos[] pos = new Pos[W + 3];
            pos[1] = new(1, 1);
            pos[2] = new(N, N);
            for (int i = 0; i < W; i++)
            {
                string[] rc = sr.ReadLine()!.Split();
                pos[i + 3] = new(int.Parse(rc[0]), int.Parse(rc[1]));
            }

            // memo[i, j] = (moved, dis, prev)
            // => 한 경찰차가 i번째 장소로 이동할 때 다른 경찰차는 j번째 장소에 있다고 할 때
            //    이때까지의 최소 이동거리는 dis이고
            //    이때 i번째 장소로 이동한 경찰차는 moved(1 or 2)이고, 이전에 prev번째 장소에 있었다.
            //    (1: 경찰차1의 초기 위치, 2: 경찰차2의 초기 위치, 3 ~ W+2: 사건 발생 위치)
            (int moved, int dis, int prev)[,] memo = new (int, int, int)[W + 3, W + 3];
            memo[3, 1] = (2, pos[2].DistanceTo(pos[3]), 2);
            memo[3, 2] = (1, pos[1].DistanceTo(pos[3]), 1);

            for (int i = 4; i < W + 3; i++)
            {
                int minDis = int.MaxValue;
                int prev = 0;

                for (int j = 1; j <= i - 2; j++)
                {
                    memo[i, j] = (
                        memo[i - 1, j].moved,
                        memo[i - 1, j].dis + pos[i - 1].DistanceTo(pos[i]),
                        j
                    );

                    int dis = memo[i - 1, j].dis + pos[j].DistanceTo(pos[i]);
                    if (dis < minDis)
                    {
                        minDis = dis;
                        prev = j;
                    }
                }

                memo[i, i - 1] = (memo[i - 1, prev].moved == 1 ? 2 : 1, minDis, prev);
            }

            int minDistance = int.MaxValue;
            int idx = 0;
            for (int i = 1; i < W + 2; i++)
            {
                if (memo[W + 2, i].dis < minDistance)
                {
                    minDistance = memo[W + 2, i].dis;
                    idx = i;
                }
            }

            Stack<int> stack = new();

            for (int i = W + 2; i >= 3; i--)
            {
                stack.Push(memo[i, idx].moved);
                idx = memo[i, idx].prev;
            }

            sw.WriteLine(minDistance);
            while(stack.Count > 0) sw.WriteLine(stack.Pop());

            sr.Close();
            sw.Close();
        }

        private class Pos
        {
            public readonly int r;
            public readonly int c;

            public Pos(int r, int c)
            {
                this.r = r;
                this.c = c;
            }

            public int DistanceTo(Pos pos)
            {
                return Math.Abs(pos.r - this.r) + Math.Abs(pos.c - this.c);
            }
        }
    }
}
