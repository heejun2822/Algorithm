namespace Algorithm.BOJ.BOJ_05679
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05679/input.txt",
        ];

        public static void Run(string[] args)
        {
            int H;

            while ((H = int.Parse(Console.ReadLine()!)) != 0)
            {
                int max = H;

                while (H != 1)
                    max = Math.Max(max, H = H % 2 == 0 ? H / 2 : 3 * H + 1);

                Console.WriteLine(max);
            }
        }
    }
}
