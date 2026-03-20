namespace Algorithm.BOJ.BOJ_09203
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09203/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string format = "yyyy-MM-dd HH:mm";
            IFormatProvider provider = System.Globalization.CultureInfo.InvariantCulture;

            int T = int.Parse(sr.ReadLine()!);

            while (T-- > 0)
            {
                string[] input = sr.ReadLine()!.Split();
                int B = int.Parse(input[0]), C = int.Parse(input[1]);

                (DateTime dateTime, bool isIn)[] timelines = new (DateTime, bool)[2 * B];

                for (int i = 0; i < B; i++)
                {
                    input = sr.ReadLine()!.Split();
                    DateTime inTime = DateTime.ParseExact($"{input[1]} {input[2]}", format, provider);
                    DateTime outTime = DateTime.ParseExact($"{input[3]} {input[4]}", format, provider).AddMinutes(C);
                    timelines[2 * i] = (inTime, true);
                    timelines[2 * i + 1] = (outTime, false);
                }

                Array.Sort(timelines);

                int cnt = 0;
                int maxCnt = 0;

                foreach ((DateTime dateTime, bool isIn) in timelines)
                {
                    if (isIn)
                        maxCnt = Math.Max(maxCnt, ++cnt);
                    else
                        cnt--;
                }

                sw.WriteLine(maxCnt);
            }

            sr.Close();
            sw.Close();
        }
    }
}
