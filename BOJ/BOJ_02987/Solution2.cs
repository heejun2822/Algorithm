namespace Algorithm.BOJ.BOJ_02987
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02987/input1.txt",
            "BOJ/BOJ_02987/input2.txt",
            "BOJ/BOJ_02987/input3.txt",
        ];

        public static void Run(string[] args)
        {
            (int x, int y)[] v = new (int, int)[3];

            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                v[i] = (int.Parse(input[0]), int.Parse(input[1]));
            }

            float area = TriangleArea(v[0].x, v[0].y, v[1].x, v[1].y, v[2].x, v[2].y);
            int cnt = 0;

            int N = int.Parse(Console.ReadLine()!);

            while (N-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                int x = int.Parse(input[0]), y = int.Parse(input[1]);

                float subAreaSum = 0;
                subAreaSum += TriangleArea(v[0].x, v[0].y, v[1].x, v[1].y, x, y);
                subAreaSum += TriangleArea(v[1].x, v[1].y, v[2].x, v[2].y, x, y);
                subAreaSum += TriangleArea(v[2].x, v[2].y, v[0].x, v[0].y, x, y);

                if (subAreaSum == area)
                    cnt++;
            }

            Console.WriteLine($"{area:F1}");
            Console.WriteLine(cnt);

            float TriangleArea(int x1, int y1, int x2, int y2, int x3, int y3)
            {
                return Math.Abs(x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2f;
            }
        }
    }
}
