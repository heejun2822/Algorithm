namespace Algorithm.BOJ.BOJ_23826
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_23826/input1.txt",
            "BOJ/BOJ_23826/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            (int x, int y, int E)[] rooms = new (int, int, int)[N + 1];
            for (int i = 0; i < N + 1; i++)
            {
                string[] info = Console.ReadLine()!.Split();
                rooms[i] = (int.Parse(info[0]), int.Parse(info[1]), int.Parse(info[2]));
            }

            int max = 0;
            for (int i = 1; i <= N; i++)
            {
                int speed = Math.Max(0, rooms[0].E - Math.Abs(rooms[i].x - rooms[0].x) - Math.Abs(rooms[i].y - rooms[0].y));
                for (int j = 1; j <= N; j++)
                    speed -= Math.Max(0, rooms[j].E - Math.Abs(rooms[i].x - rooms[j].x) - Math.Abs(rooms[i].y - rooms[j].y));

                max = Math.Max(max, speed);
            }

            Console.WriteLine(max > 0 ? max : "IMPOSSIBLE");
        }
    }
}
