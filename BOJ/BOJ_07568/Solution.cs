namespace Algorithm.BOJ.BOJ_07568
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_07568/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            (int x, int y)[] size = new (int, int)[N];
            int[] ranks = new int[N];

            for (int i = 0; i < N; i++)
            {
                string[] input = Console.ReadLine()!.Split();

                size[i] = (int.Parse(input[0]), int.Parse(input[1]));
                ranks[i]++;

                for (int j = 0; j < i; j++)
                {
                    if (size[i].x < size[j].x && size[i].y < size[j].y)
                        ranks[i]++;
                    else if (size[i].x > size[j].x && size[i].y > size[j].y)
                        ranks[j]++;
                }
            }

            Console.WriteLine(string.Join(' ', ranks));
        }
    }
}
