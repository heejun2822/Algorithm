namespace Algorithm.BOJ.BOJ_02987
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02987/input1.txt",
            "BOJ/BOJ_02987/input2.txt",
            "BOJ/BOJ_02987/input3.txt",
        ];

        public static void Run(string[] args)
        {
            (int x, int y)[] v = new (int, int)[4];

            for (int i = 0; i < 3; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                v[i] = (int.Parse(input[0]), int.Parse(input[1]));
            }
            v[3] = v[0];

            float area = Math.Abs(v[0].x * (v[1].y - v[2].y) + v[1].x * (v[2].y - v[0].y) + v[2].x * (v[0].y - v[1].y)) / 2f;
            int cnt = 0;

            int N = int.Parse(Console.ReadLine()!);

            while (N-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                int x = int.Parse(input[0]), y = int.Parse(input[1]);

                if (IsInsideTriangle(x, y))
                    cnt++;
            }

            Console.WriteLine($"{area:F1}");
            Console.WriteLine(cnt);

            bool IsInsideTriangle(int x, int y)
            {
                bool hasCCW = false;
                bool hasCW = false;

                for (int i = 0; i < 3; i++)
                {
                    (int x, int y) l1 = (v[i + 1].x - v[i].x, v[i + 1].y - v[i].y);
                    (int x, int y) l2 = (x - v[i].x, y - v[i].y);
                    int cp = l1.x * l2.y - l1.y * l2.x;
                    hasCCW |= cp > 0;
                    hasCW |= cp < 0;
                }

                return hasCCW ^ hasCW;
            }
        }
    }
}
