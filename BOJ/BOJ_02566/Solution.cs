namespace Algorithm.BOJ.BOJ_02566
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02566/input.txt",
        ];

        public static void Run(string[] args)
        {
            int max = 0;
            int r = 1;
            int c = 1;
            for (int i = 0; i < 9; i++)
            {
                string[] row = Console.ReadLine()!.Split();
                for (int j = 0; j < 9; j++)
                {
                    int ele = int.Parse(row[j]);
                    if (ele <= max) continue;
                    max = ele;
                    r = i + 1;
                    c = j + 1;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine($"{r} {c}");
        }
    }
}
