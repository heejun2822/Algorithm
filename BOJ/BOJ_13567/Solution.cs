namespace Algorithm.BOJ.BOJ_13567
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13567/input1.txt",
            "BOJ/BOJ_13567/input2.txt",
            "BOJ/BOJ_13567/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] mn = Console.ReadLine()!.Split();
            int M = int.Parse(mn[0]);
            int n = int.Parse(mn[1]);

            int x = 0, y = 0;
            int dirX = 1, dirY = 0;

            for (int _ = 0; _ < n; _++)
            {
                string[] command = Console.ReadLine()!.Split();

                if (command[0][0] == 'M')
                {
                    int d = int.Parse(command[1]);
                    x += dirX * d;
                    y += dirY * d;

                    if (x < 0 || x > M || y < 0 || y > M)
                    {
                        Console.WriteLine("-1");
                        return;
                    }
                }
                else
                {
                    int dir = int.Parse(command[1]);
                    (dirX, dirY) = dir == 0 ? (-dirY, dirX) : (dirY, -dirX);
                }
            }

            Console.WriteLine($"{x} {y}");
        }
    }
}
