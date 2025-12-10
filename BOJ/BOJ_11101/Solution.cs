namespace Algorithm.BOJ.BOJ_11101
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11101/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            while (T-- > 0)
            {
                Dictionary<string, int> requiredTime = new();

                foreach (string str in sr.ReadLine()!.Split(','))
                {
                    string[] info = str.Split(':');
                    requiredTime.Add(info[0], int.Parse(info[1]));
                }

                int minTime = 1000;

                foreach (string str in sr.ReadLine()!.Split('|'))
                {
                    int time = 0;

                    foreach (string cond in str.Split('&'))
                        time = Math.Max(time, requiredTime[cond]);

                    minTime = Math.Min(minTime, time);
                }

                sw.WriteLine(minTime);
            }

            sr.Close();
            sw.Close();
        }
    }
}
