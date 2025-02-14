namespace Algorithm.BOJ.BOJ_18766
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_18766/input.txt",
        ];

        public static void Run(string[] args)
        {
            Dictionary<char, int> map = new() { {'R', 0}, {'Y', 1}, {'B', 2} };

            int[,] counts = new int[3, 10];

            int T = int.Parse(Console.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 10; j++)
                        counts[i, j] = 0;

                int n = int.Parse(Console.ReadLine()!);

                for (int i = 0; i < n; i++)
                {
                    int color = map[(char)Console.Read()];
                    int number = Console.Read() - '0';
                    counts[color, number]++;
                    Console.Read();
                }
                for (int i = 0; i < n; i++)
                {
                    int color = map[(char)Console.Read()];
                    int number = Console.Read() - '0';
                    counts[color, number]--;
                    Console.Read();
                }

                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 10; j++)
                        if (counts[i, j] != 0)
                            goto Cheat;

                Console.WriteLine("NOT CHEATER");
                continue;

                Cheat:
                Console.WriteLine("CHEATER");
            }
        }
    }
}
