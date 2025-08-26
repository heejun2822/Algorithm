namespace Algorithm.BOJ.BOJ_20149
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20149/input1.txt",
            "BOJ/BOJ_20149/input2.txt",
            "BOJ/BOJ_20149/input3.txt",
            "BOJ/BOJ_20149/input4.txt",
            "BOJ/BOJ_20149/input5.txt",
            "BOJ/BOJ_20149/input6.txt",
            "BOJ/BOJ_20149/input7.txt",
            "BOJ/BOJ_20149/input8.txt",
            "BOJ/BOJ_20149/input9.txt",
            "BOJ/BOJ_20149/input10.txt",
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
                    int ay1 = Math.Min(y1, y2), ay2 = Math.Max(y1, y2);
                    int by1 = Math.Min(y3, y4), by2 = Math.Max(y3, y4);
                    if (by1 <= ay2 && by2 >= ay1)
                    {
                        Console.WriteLine("1");
                        if (by1 == ay2)
                            Console.WriteLine($"{x1} {ay2}");
                        else if (by2 == ay1)
                            Console.WriteLine($"{x1} {ay1}");
                    }
                    else
                        Console.WriteLine("0");
                }
                else
                {
                    int ax1 = Math.Min(x1, x2), ax2 = Math.Max(x1, x2);
                    int bx1 = Math.Min(x3, x4), bx2 = Math.Max(x3, x4);
                    if (bx1 <= ax2 && bx2 >= ax1)
                    {
                        Console.WriteLine("1");
                        if (bx1 == ax2)
                            Console.WriteLine($"{ax2} {(ax2 == x1 ? y1 : y2)}");
                        else if (bx2 == ax1)
                            Console.WriteLine($"{ax1} {(ax1 == x1 ? y1 : y2)}");
                    }
                    else
                        Console.WriteLine("0");
                }
            }
            else if (ccw1 * ccw2 <= 0 && ccw3 * ccw4 <= 0)
            {
                Console.WriteLine("1");
                if (x1 == x2)
                {
                    double a = Math.Abs(x1 - x3);
                    double b = Math.Abs(x1 - x4);
                    Console.WriteLine($"{x1} {(y3 * b + y4 * a) / (a + b)}");
                }
                else if (x3 == x4)
                {
                    double a = Math.Abs(x3 - x1);
                    double b = Math.Abs(x3 - x2);
                    Console.WriteLine($"{x3} {(y1 * b + y2 * a) / (a + b)}");
                }
                else
                {
                    double a1 = (double)(y2 - y1) / (x2 - x1);
                    double b1 = ((double)y1 * (x2 - x1) - (double)x1 * (y2 - y1)) / (x2 - x1);
                    double a2 = (double)(y4 - y3) / (x4 - x3);
                    double b2 = ((double)y3 * (x4 - x3) - (double)x3 * (y4 - y3)) / (x4 - x3);
                    double x = (b2 - b1) / (a1 - a2);
                    double y = a1 * x + b1;
                    Console.WriteLine($"{x} {y}");
                }
            }
            else
            {
                Console.WriteLine("0");
            }

            int CCW(long x1, long y1, long x2, long y2, long x3, long y3)
            {
                long cp = (x2 - x1) * (y3 - y2) - (y2 - y1) * (x3 - x2);
                return cp > 0 ? 1 : cp < 0 ? -1 : 0;
            }
        }
    }
}
