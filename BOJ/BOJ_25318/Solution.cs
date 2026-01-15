namespace Algorithm.BOJ.BOJ_25318
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25318/input1.txt",
            "BOJ/BOJ_25318/input2.txt",
            "BOJ/BOJ_25318/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int[] days = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int[] accDays = new int[13];

            for (int m = 1; m <= 12; m++)
                accDays[m] = accDays[m - 1] + days[m];

            int N = int.Parse(Console.ReadLine()!);

            (int t, int l)[] opinions = new (int, int)[N + 1];

            for (int i = 1; i <= N; i++)
            {
                string[] input = Console.ReadLine()!.Split(' ', '/', ':');
                int Y = int.Parse(input[0]), M = int.Parse(input[1]), D = int.Parse(input[2]);
                int h = int.Parse(input[3]), m = int.Parse(input[4]), s = int.Parse(input[5]);
                int l = int.Parse(input[6]);

                int t = (Y - 2019) * 365 + accDays[M - 1] + D - 1;
                if (Y > 2020 || (Y == 2020 && M > 2))
                    t++;
                t = t * 24 + h;
                t = t * 60 + m;
                t = t * 60 + s;

                opinions[i] = (t, l);
            }

            double sumP = 0, sumPL = 0;

            for (int i = 1; i <= N; i++)
            {
                double exp = (opinions[N].t - opinions[i].t) / 31_536_000.0;
                double p = Math.Max( Math.Pow(0.5, exp), Math.Pow(0.9, N - i) );
                sumP += p;
                sumPL += p * opinions[i].l;
            }

            int X = N == 0 ? 0 : (int)Math.Round(sumPL / sumP);

            Console.WriteLine(X);
        }
    }
}
