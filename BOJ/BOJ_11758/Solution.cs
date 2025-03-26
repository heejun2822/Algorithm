namespace Algorithm.BOJ.BOJ_11758
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11758/input1.txt",
            "BOJ/BOJ_11758/input2.txt",
            "BOJ/BOJ_11758/input3.txt",
        ];

        public static void Run(string[] args)
        {
            (int x, int y)[] P = new (int, int)[3];
            for (int i = 0; i < 3; i++)
            {
                string[] xy = Console.ReadLine()!.Split();
                P[i] = (int.Parse(xy[0]), int.Parse(xy[1]));
            }

            (int x, int y) l1 = (P[1].x - P[0].x, P[1].y - P[0].y);
            (int x, int y) l2 = (P[2].x - P[1].x, P[2].y - P[1].y);
            int crossProduct = l1.x * l2.y - l1.y * l2.x;

            Console.WriteLine(crossProduct > 0 ? "1" : crossProduct < 0 ? "-1" : "0");
        }
    }
}
