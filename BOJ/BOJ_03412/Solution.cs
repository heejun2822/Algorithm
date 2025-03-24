namespace Algorithm.BOJ.BOJ_03412
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_03412/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                int n = int.Parse(sr.ReadLine()!);

                int totalScore = 0;

                for (int i = 0; i < n; i++)
                {
                    string[] xy = sr.ReadLine()!.Split();
                    int x = int.Parse(xy[0]);
                    int y = int.Parse(xy[1]);

                    float r = MathF.Sqrt(x * x + y * y);
                    if (r > 200) continue;

                    totalScore += r == 0 ? 10 : (int)(200 - r) / 20 + 1;
                }

                sw.WriteLine(totalScore);
            }

            sr.Close();
            sw.Close();
        }
    }
}
