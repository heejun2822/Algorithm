namespace Algorithm.BOJ.BOJ_02562
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02562/input.txt",
        ];

        public static void Run(string[] args)
        {
            int max = 0;
            int index = 0;
            for (int i = 0; i < 9; i++)
            {
                int num = int.Parse(Console.ReadLine()!);
                if (num < max) continue;
                max = num;
                index = i;
            }
            Console.WriteLine(max);
            Console.WriteLine(index + 1);
        }
    }
}
