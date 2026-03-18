namespace Algorithm.BOJ.BOJ_24243
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_24243/input1.txt",
            "BOJ/BOJ_24243/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int h = int.Parse(input[0]), w = int.Parse(input[1]), n = int.Parse(input[2]);

            bool[,,] trainStops = new bool[n, h, w];
            bool[,] screen = new bool[h, w];

            for (int i = 0; i < n; i++)
            {
                for (int r = 0; r < h; r++)
                {
                    string row = Console.ReadLine()!;
                    for (int c = 0; c < w; c++)
                        trainStops[i, r, c] = row[c] == 'x';
                }
            }
            
            for (int r = 0; r < h; r++)
            {
                string row = Console.ReadLine()!;
                for (int c = 0; c < w; c++)
                    screen[r, c] = row[c] == 'x';
            }

            bool nextStopDecided = false;

            for (int i = 0; i < n; i++)
                if (CanBeNextStop(i) && !(nextStopDecided = !nextStopDecided))
                    break;

            Console.WriteLine(nextStopDecided ? "yes" : "no");

            bool CanBeNextStop(int i)
            {
                for (int r = 0; r < h; r++)
                    for (int c = 0; c < w; c++)
                        if (screen[r, c] && !trainStops[i, r, c])
                            return false;
                return true;
            }
        }
    }
}
