namespace Algorithm.BOJ.BOJ_17387
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_17387/input1.txt",
            "BOJ/BOJ_17387/input2.txt",
            "BOJ/BOJ_17387/input3.txt",
            "BOJ/BOJ_17387/input4.txt",
            "BOJ/BOJ_17387/input5.txt",
            "BOJ/BOJ_17387/input6.txt",
            "BOJ/BOJ_17387/input7.txt",
            "BOJ/BOJ_17387/input8.txt",
            "BOJ/BOJ_17387/input9.txt",
        ];

        public static void Run(string[] args)
        {
            string[] L1 = Console.ReadLine()!.Split();
            int x1 = int.Parse(L1[0]), y1 = int.Parse(L1[1]);
            int x2 = int.Parse(L1[2]), y2 = int.Parse(L1[3]);
            string[] L2 = Console.ReadLine()!.Split();
            int x3 = int.Parse(L2[0]), y3 = int.Parse(L2[1]);
            int x4 = int.Parse(L2[2]), y4 = int.Parse(L2[3]);

            int ccw1 = CCW(x1, y1, x2, y2, x3, y3);
            int ccw2 = CCW(x1, y1, x2, y2, x4, y4);
            int ccw3 = CCW(x3, y3, x4, y4, x1, y1);
            int ccw4 = CCW(x3, y3, x4, y4, x2, y2);

            if (ccw1 == 0 && ccw2 == 0)
            {
                if (x1 == x2)
                {
                    int aY1 = Math.Min(y1, y2), aY2 = Math.Max(y1, y2);
                    int bY1 = Math.Min(y3, y4), bY2 = Math.Max(y3, y4);
                    if (bY1 <= aY2 && bY2 >= aY1)
                        Console.WriteLine("1");
                    else
                        Console.WriteLine("0");
                }
                else
                {
                    int aX1 = Math.Min(x1, x2), aX2 = Math.Max(x1, x2);
                    int bX1 = Math.Min(x3, x4), bX2 = Math.Max(x3, x4);
                    if (bX1 <= aX2 && bX2 >= aX1)
                        Console.WriteLine("1");
                    else
                        Console.WriteLine("0");
                }
                return;
            }

            if (ccw1 * ccw2 <= 0 && ccw3 * ccw4 <= 0)
                Console.WriteLine("1");
            else
                Console.WriteLine("0");

            int CCW(long x1, long y1, long x2, long y2, long x3, long y3)
            {
                long cp = (x2 - x1) * (y3 - y2) - (y2 - y1) * (x3 - x2);
                return cp > 0 ? 1 : cp < 0 ? -1 : 0;
            }
        }
    }
}
