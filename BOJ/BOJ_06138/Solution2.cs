namespace Algorithm.BOJ.BOJ_06138
{
    public class Solution2
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

            int[] locations = new int[N];

            for (int i = 0; i < N; i++)
                locations[i] = int.Parse(sr.ReadLine()!);

            Array.Sort(locations, (a, b) => Math.Abs(a) - Math.Abs(b));

            int currentX = 0;
            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                int x = locations[i];
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
