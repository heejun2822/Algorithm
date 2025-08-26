namespace Algorithm.BOJ.BOJ_20300
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20300/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);
            long[] t = Array.ConvertAll(sr.ReadLine()!.Split(), long.Parse);

            Array.Sort(t);

            long minM = 0;
            int l = 0, h = N - 1;

            if (N % 2 == 1)
                minM = t[h--];

            while (l < h)
                minM = Math.Max(minM, t[l++] + t[h--]);

            sw.WriteLine(minM);

            sr.Close();
            sw.Close();
        }
    }
}
