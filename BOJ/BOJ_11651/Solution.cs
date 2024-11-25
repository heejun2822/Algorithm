namespace Algorithm.BOJ.BOJ_11651
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11651/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());
            int N = int.Parse(sr.ReadLine()!);
            (int x, int y)[] points = new (int x, int y)[N];
            for (int i = 0; i < N; i++)
            {
                string[] point = sr.ReadLine()!.Split();
                points[i] = (int.Parse(point[0]), int.Parse(point[1]));
            }
            Array.Sort(points, (a, b) => a.y != b.y ? a.y - b.y : a.x - b.x);
            foreach ((int x, int y) in points) sw.WriteLine($"{x} {y}");
            sr.Close();
            sw.Close();
        }
    }
}
