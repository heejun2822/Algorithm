namespace Algorithm.BOJ.BOJ_22133
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_22133/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = 3;
            (int w, int h)[] fields = new (int, int)[N];

            while (true)
            {
                string[] input = Console.ReadLine()!.Split();

                if (input[0] == "0") break;

                for (int i = 0; i < N; i++)
                {
                    int w = int.Parse(input[2 * i]), h = int.Parse(input[2 * i + 1]);
                    if (w < h)
                        (w, h) = (h, w);
                    fields[i] = (w, h);
                }

                Array.Sort(fields, (a, b) => b.w - a.w);

                int maxH = 0;
                int minArea = 0;

                for (int i = 0; i < N; i++)
                {
                    if (fields[i].h <= maxH) continue;

                    minArea += fields[i].w * (fields[i].h - maxH);
                    maxH = fields[i].h;
                }

                Console.WriteLine(minArea);
            }
        }
    }
}
