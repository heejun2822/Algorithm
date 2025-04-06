namespace Algorithm.BOJ.BOJ_26537
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_26537/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            for (int _ = 0; _ < n; _++)
            {
                int z = int.Parse(Console.ReadLine()!);

                (int x, int y)[] coordinates = new (int, int)[z];

                int minDist = int.MaxValue;
                (int x, int y)[] pair = new (int, int)[2];

                for (int i = 0; i < z; i++)
                {
                    string[] xy = Console.ReadLine()!.Split();
                    int x = int.Parse(xy[0]);
                    int y = int.Parse(xy[1]);

                    coordinates[i] = (x, y);

                    for (int j = 0; j < i; j++)
                    {
                        int dist = (x - coordinates[j].x) * (x - coordinates[j].x) + (y - coordinates[j].y) * (y - coordinates[j].y);

                        if (dist < minDist)
                        {
                            minDist = dist;
                            pair[0] = coordinates[j];
                            pair[1] = coordinates[i];
                            if (x < coordinates[j].x || x == coordinates[j].x && y < coordinates[j].y)
                                (pair[0], pair[1]) = (pair[1], pair[0]);
                        }
                        else if (dist == minDist)
                        {
                            (int x, int y)[] tempPair = { coordinates[j], coordinates[i] };
                            if (x < coordinates[j].x || x == coordinates[j].x && y < coordinates[j].y)
                                (tempPair[0], tempPair[1]) = (tempPair[1], tempPair[0]);

                            if (tempPair[0].x < pair[0].x)
                                pair = tempPair;
                            else if (tempPair[0].x == pair[0].x)
                            {
                                if (tempPair[0].y < pair[0].y)
                                    pair = tempPair;
                                else if (tempPair[0].y == pair[0].y)
                                {
                                    if (tempPair[1].x < pair[1].x)
                                        pair = tempPair;
                                    else if (tempPair[1].x == pair[1].x)
                                    {
                                        if (tempPair[1].y < pair[1].y)
                                            pair = tempPair;
                                    }
                                }
                            }
                        }
                    }
                }

                Console.WriteLine($"{pair[0].x} {pair[0].y} {pair[1].x} {pair[1].y}");
            }
        }
    }
}
