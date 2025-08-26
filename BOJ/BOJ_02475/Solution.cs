namespace Algorithm.BOJ.BOJ_02475
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02475/input.txt",
        ];

        public static void Run(string[] args)
        {
            int sum = 0;
            for (int _ = 0; _ < 5; _++)
            {
                int num = Console.Read() - '0';
                sum += num * num;
                Console.Read();
            }

            Console.WriteLine(sum % 10);
        }
    }
}
