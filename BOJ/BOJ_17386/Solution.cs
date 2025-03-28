namespace Algorithm.BOJ.BOJ_17386
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_17386/input1.txt",
            "BOJ/BOJ_17386/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] L1 = Console.ReadLine()!.Split();
            int x1 = int.Parse(L1[0]), y1 = int.Parse(L1[1]);
            int x2 = int.Parse(L1[2]), y2 = int.Parse(L1[3]);
            string[] L2 = Console.ReadLine()!.Split();
            int x3 = int.Parse(L2[0]), y3 = int.Parse(L2[1]);
            int x4 = int.Parse(L2[2]), y4 = int.Parse(L2[3]);

            if (
                CCW(x1, y1, x2, y2, x3, y3) * CCW(x1, y1, x2, y2, x4, y4) < 0 &&
                CCW(x3, y3, x4, y4, x1, y1) * CCW(x3, y3, x4, y4, x2, y2) < 0
            )
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
