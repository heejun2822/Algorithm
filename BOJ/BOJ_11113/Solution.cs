namespace Algorithm.BOJ.BOJ_11113
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11113/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine()!);
            (double x, double y)[] controlPoints = new (double, double)[n];
            for (int i = 0; i < n; i++)
            {
                string[] numbers = sr.ReadLine()!.Split();
                controlPoints[i] = (double.Parse(numbers[0]), double.Parse(numbers[1]));
            }

            int m = int.Parse(sr.ReadLine()!);
            for (int _ = 0; _ < m; _++)
            {
                int p = int.Parse(sr.ReadLine()!);
                int[] route = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

                double trackDistance = 0;

                for (int i = 1; i < p; i++)
                {
                    double dx = controlPoints[route[i]].x - controlPoints[route[i - 1]].x;
                    double dy = controlPoints[route[i]].y - controlPoints[route[i - 1]].y;

                    trackDistance += Math.Sqrt(dx * dx + dy * dy);
                }

                sw.WriteLine(Math.Round(trackDistance));
            }

            sr.Close();
            sw.Close();
        }
    }
}
