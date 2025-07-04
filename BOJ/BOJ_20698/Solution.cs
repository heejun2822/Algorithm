namespace Algorithm.BOJ.BOJ_20698
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_20698/input1.txt",
            "BOJ/BOJ_20698/input2.txt",
            "BOJ/BOJ_20698/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            int minX = 1_000_000, maxX = -1_000_000;
            int minY = 1_000_000, maxY = -1_000_000;

            for (int _ = 0; _ < N; _++)
            {
                string[] xy = sr.ReadLine()!.Split();
                int x = int.Parse(xy[0]);
                int y = int.Parse(xy[1]);

                minX = Math.Min(minX, x);
                maxX = Math.Max(maxX, x);
                minY = Math.Min(minY, y);
                maxY = Math.Max(maxY, y);
            }

            int minL = (maxX - minX + 1) / 2;
            int minW = (maxY - minY + 1) / 2;

            sw.WriteLine($"{minL} {minW}");

            sr.Close();
            sw.Close();
        }
    }
}
