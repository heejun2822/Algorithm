namespace Algorithm.BOJ.BOJ_03154
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_03154/input1.txt",
            "BOJ/BOJ_03154/input2.txt",
            "BOJ/BOJ_03154/input3.txt",
        ];

        public static void Run(string[] args)
        {
            (int x, int y)[] keyboard =
            {
                (4, 2),
                (1, 1), (1, 2), (1, 3),
                (2, 1), (2, 2), (2, 3),
                (3, 1), (3, 2), (3, 3),
            };

            string[] time = Console.ReadLine()!.Split(':');
            int hours = int.Parse(time[0]);
            int minutes = int.Parse(time[1]);

            int minEffort = int.MaxValue;
            int optH = 0;
            int optM = 0;

            int h = hours;
            while (h < 100)
            {
                int m = minutes;
                while (m < 100)
                {
                    int key1 = h / 10, key2 = h % 10, key3 = m / 10, key4 = m % 10;
                    int effort = Effort(key1, key2) + Effort(key2, key3) + Effort(key3, key4);
                    if (effort < minEffort)
                    {
                        minEffort = effort;
                        optH = h;
                        optM = m;
                    }
                    m += 60;
                }
                h += 24;
            }

            Console.WriteLine(optH.ToString("D2") + ":" + optM.ToString("D2"));

            int Effort(int a, int b)
            {
                return Math.Abs(keyboard[a].x - keyboard[b].x) + Math.Abs(keyboard[a].y - keyboard[b].y);
            }
        }
    }
}
