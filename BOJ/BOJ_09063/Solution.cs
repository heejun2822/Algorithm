namespace Algorithm.BOJ.BOJ_09063
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09063/input1.txt",
            "BOJ/BOJ_09063/input2.txt",
            "BOJ/BOJ_09063/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int minX = 10000, maxX = -10000, minY = 10000, maxY = -10000;
            for (int _ = 0; _ < N; _++)
            {
                string[] point = Console.ReadLine()!.Split();
                int x = int.Parse(point[0]);
                int y = int.Parse(point[1]);
                if (x < minX) minX = x;
                if (x > maxX) maxX = x;
                if (y < minY) minY = y;
                if (y > maxY) maxY = y;
            }
            Console.WriteLine((maxX - minX) * (maxY - minY));
        }
    }
}
