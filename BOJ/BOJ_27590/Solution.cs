namespace Algorithm.BOJ.BOJ_27590
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_27590/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] info = Console.ReadLine()!.Split();
            int ds = int.Parse(info[0]);
            int ys = int.Parse(info[1]);
            int fs = (ys - ds) % ys;
            info = Console.ReadLine()!.Split();
            int dm = int.Parse(info[0]);
            int ym = int.Parse(info[1]);
            int fm = (ym - dm) % ym;
            for (int i = 1; i <= 5000; i++)
            {
                if (i % ys == fs && i % ym == fm)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
