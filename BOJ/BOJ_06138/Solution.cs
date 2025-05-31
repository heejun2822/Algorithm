namespace Algorithm.BOJ.BOJ_06138
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_06138/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] tn = sr.ReadLine()!.Split();
            int T = int.Parse(tn[0]);
            int N = int.Parse(tn[1]);

            PriorityQueue<int, int> locations = new(N);

            for (int _ = 0; _ < N; _++)
            {
                int x = int.Parse(sr.ReadLine()!);
                locations.Enqueue(x, Math.Abs(x));
            }

            int currentX = 0;
            int cnt = 0;

            while (locations.Count > 0)
            {
                int x = locations.Dequeue();
                int d = Math.Abs(currentX - x);

                if (d > T) break;

                T -= d;
                currentX = x;
                cnt++;
            }

            sw.WriteLine(cnt);

            sr.Close();
            sw.Close();
        }
    }
}
