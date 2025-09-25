namespace Algorithm.BOJ.BOJ_16972
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16972/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = 814;
            (int x, int y) min = (-8140, -8140);
            (int x, int y) max = (8140, 8140);

            int w = 1;
            int h = (int)(w * (2 / Math.Sqrt(3)));

            while (true)
            {
                int l = h / 2 + 1;
                int cnt = h % 2 == 1 ? (w + 1) * l + w * l : (w + 1) * l + w * (l - 1);

                if (cnt >= n) break;

                h = (int)(++w * (2 / Math.Sqrt(3)));
            }

            (int x, int y) offset = ((max.x - min.x) / w, (max.y - min.y) / h);

            System.Text.StringBuilder output = new();

            int c = 0, r = 0;
            int x = min.x, y = min.y;

            output.AppendLine($"{x + 1} {y}");

            c++;
            x = min.x + offset.x;

            for (int _ = 1; _ < n; _++)
            {
                output.AppendLine($"{x} {y}");

                if (c == w)
                {
                    r++;
                    y += offset.y;

                    if (r % 2 == 1)
                    {
                        c = 1;
                        x = min.x + offset.x / 2;
                    }
                    else
                    {
                        c = 0;
                        x = min.x;
                    }
                }
                else
                {
                    c++;
                    x += offset.x;
                }
            }

            Console.WriteLine(output);
        }
    }
}
