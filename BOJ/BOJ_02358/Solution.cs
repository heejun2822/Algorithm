namespace Algorithm.BOJ.BOJ_02358
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02358/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int n = int.Parse(sr.ReadLine()!);

            Dictionary<int, int> coordX = new();
            Dictionary<int, int> coordY = new();

            for (int _ = 0; _ < n; _++)
            {
                string[] xy = sr.ReadLine()!.Split();
                int x = int.Parse(xy[0]);
                int y = int.Parse(xy[1]);

                if (!coordX.TryAdd(x, 1)) coordX[x]++;
                if (!coordY.TryAdd(y, 1)) coordY[y]++;
            }

            int cnt = 0;

            foreach (int cx in coordX.Values)
                if (cx >= 2) cnt++;
            foreach (int cy in coordY.Values)
                if (cy >= 2) cnt++;

            sw.WriteLine(cnt);

            sr.Close();
            sw.Close();
        }
    }
}
