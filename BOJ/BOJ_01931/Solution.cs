namespace Algorithm.BOJ.BOJ_01931
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01931/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            (int s, int e)[] meetings = new (int, int)[N];
            for (int i = 0; i < N; i++)
            {
                string[] info = Console.ReadLine()!.Split();
                meetings[i] = (int.Parse(info[0]), int.Parse(info[1]));
            }
            Array.Sort(meetings);

            int t = 0, cnt = 0;
            foreach ((int s, int e) in meetings)
            {
                if (e < t) t = e;
                else if (s >= t) { t = e; cnt++; }
            }

            Console.WriteLine(cnt);
        }
    }
}
