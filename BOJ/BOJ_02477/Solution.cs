namespace Algorithm.BOJ.BOJ_02477
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02477/input.txt",
        ];

        public static void Run(string[] args)
        {
            int K = int.Parse(Console.ReadLine()!);

            int[] lengths = new int[6];
            int maxW = 0, idxW = 0;
            int maxH = 0, idxH = 0;

            for (int i = 0; i < 6; i++)
            {
                string[] input = Console.ReadLine()!.Split();
                int dir = int.Parse(input[0]);
                int len = int.Parse(input[1]);

                lengths[i] = len;
                if ((dir == 1 || dir == 2) && len > maxW)
                {
                    maxW = len;
                    idxW = i;
                }
                else if ((dir == 3 || dir == 4) && len > maxH)
                {
                    maxH = len;
                    idxH = i;
                }
            }

            int idx = Math.Abs(idxW - idxH) == 1 ? Math.Min(idxW, idxH) : Math.Max(idxW, idxH);
            int bigSquareArea = lengths[idx] * lengths[(idx + 1) % 6];
            int smallSquareArea = lengths[(idx + 3) % 6] * lengths[(idx + 4) % 6];
            int area = bigSquareArea - smallSquareArea;

            Console.WriteLine(area * K);
        }
    }
}
