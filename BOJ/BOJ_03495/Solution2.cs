namespace Algorithm.BOJ.BOJ_03495
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
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

            int area = 0;

            for (int _ = 0; _ < h; _++)
            {
                string row = Console.ReadLine()!;
                bool isInside = false;

                for (int i = 0; i < w; i++)
                {
                    if (row[i] != '.')
                        isInside = !isInside;
                    if (isInside)
                        area++;
                }
            }

            Console.WriteLine(area);
        }
    }
}
