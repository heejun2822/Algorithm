namespace Algorithm.BOJ.BOJ_12782
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_12782/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                string[] nm = sr.ReadLine()!.Split();
                string N = nm[0];
                string M = nm[1];

                int[] cnt = new int[2];

                for (int i = 0; i < N.Length; i++)
                    if (N[i] != M[i]) cnt[N[i] - '0']++;

                sw.WriteLine(Math.Max(cnt[0], cnt[1]));
            }

            sr.Close();
            sw.Close();
        }
    }
}
