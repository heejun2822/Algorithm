namespace Algorithm.BOJ.BOJ_03495
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_03495/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int h = int.Parse(input[0]);
            int w = int.Parse(input[1]);

            bool[] isOdd = new bool[w];
            int area = 0;

            for (int y = h; y > 0; y--)
            {
                string row = Console.ReadLine()!;

                for (int x = 0; x < w; x++)
                {
                    if (row[x] == '.') continue;

                    isOdd[x] = !isOdd[x];
                    area += y * (isOdd[x] ? 1 : -1);
                }
            }

            Console.WriteLine(area);
        }
    }
}
