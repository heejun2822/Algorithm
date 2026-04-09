namespace Algorithm.BOJ.BOJ_21593
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_21593/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            System.Collections.BitArray exists = new(24 * 60 * 60);
            List<int> hours = new(24);
            List<int> minutes = new(60);
            List<int> seconds = new(60);

            int uniqueCnt = 0;
            int totalCnt = 0;

            while (n-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                Parse(input[0], hours);
                Parse(input[1], minutes);
                Parse(input[2], seconds);

                foreach (int h in hours)
                {
                    foreach (int m in minutes)
                    {
                        foreach (int s in seconds)
                        {
                            int time = h * 3600 + m * 60 + s;
                            if (!exists[time])
                            {
                                exists[time] = true;
                                uniqueCnt++;
                            }
                            totalCnt++;
                        }
                    }
                }
            }

            Console.WriteLine($"{uniqueCnt} {totalCnt}");

            void Parse(string str, List<int> list)
            {
                list.Clear();

                if (str == "*")
                {
                    for (int i = 0; i < list.Capacity; i++)
                        list.Add(i);
                    return;
                }

                foreach (string range in str.Split(','))
                {
                    string[] values = range.Split('-');
                    int low = int.Parse(values[0]);
                    int high = values.Length == 1 ? low : int.Parse(values[1]);
                    for (int i = low; i <= high; i++)
                        list.Add(i);
                }
            }
        }
    }
}
