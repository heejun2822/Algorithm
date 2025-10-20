namespace Algorithm.BOJ.BOJ_22867
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_22867/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = int.Parse(sr.ReadLine()!);

            (int time, bool enter)[] times = new (int, bool)[2 * N];

            for (int i = 0; i < N; i++)
            {
                string[] input = sr.ReadLine()!.Split();
                times[2 * i] = (ParseTime(input[0]), true);
                times[2 * i + 1] = (ParseTime(input[1]), false);
            }

            Array.Sort(times);

            int cnt = 0;
            int maxCnt = 0;

            foreach ((int time, bool enter) in times)
            {
                if (enter)
                    maxCnt = Math.Max(maxCnt, ++cnt);
                else
                    cnt--;
            }

            sw.WriteLine(maxCnt);

            sr.Close();
            sw.Close();

            int ParseTime(string timeStr)
            {
                string[] nums = timeStr.Split(':', '.');
                int time = 0;
                time += int.Parse(nums[0]);
                time *= 60;
                time += int.Parse(nums[1]);
                time *= 60;
                time += int.Parse(nums[2]);
                time *= 1000;
                time += int.Parse(nums[3]);
                return time;
            }
        }
    }
}
