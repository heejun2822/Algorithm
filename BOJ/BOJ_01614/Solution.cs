namespace Algorithm.BOJ.BOJ_01614
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01614/input1.txt",
            "BOJ/BOJ_01614/input2.txt",
            "BOJ/BOJ_01614/input3.txt",
            "BOJ/BOJ_01614/input4.txt",
            "BOJ/BOJ_01614/input5.txt",
            "BOJ/BOJ_01614/input6.txt",
        ];

        public static void Run(string[] args)
        {
            int finger = int.Parse(Console.ReadLine()!);
            int limit = int.Parse(Console.ReadLine()!);

            long maxCount = finger switch
            {
                1 => 8L * limit,
                2 => 8L * (limit / 2) + (limit % 2 == 0 ? 1 : 7),
                3 => 8L * (limit / 2) + (limit % 2 == 0 ? 2 : 6),
                4 => 8L * (limit / 2) + (limit % 2 == 0 ? 3 : 5),
                5 => 8L * limit + 4,
                _ => 0,
            };

            Console.WriteLine(maxCount);
        }
    }
}
