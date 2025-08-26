namespace Algorithm.BOJ.BOJ_05575
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05575/input.txt",
        ];

        public static void Run(string[] args)
        {
            for (int _ = 0; _ < 3; _++)
            {
                int[] record = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

                int h = record[3] - record[0];
                int m = record[4] - record[1];
                int s = record[5] - record[2];
                if (s < 0) { s += 60; m -= 1; }
                if (m < 0) { m += 60; h -= 1; }

                Console.WriteLine($"{h} {m} {s}");
            }
        }
    }
}
