namespace Algorithm.BOJ.BOJ_32986
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_32986/input1.txt",
            "BOJ/BOJ_32986/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int X = int.Parse(input[0]);
            int Y = int.Parse(input[1]);
            int Z = int.Parse(input[2]);

            if (X == 3 && Y == 3 && Z == 3)
            {
                Console.WriteLine(0);
            }
            else
            {
                int min = Math.Min(X, Math.Min(Y, Z));
                Console.WriteLine((min - 1) / 2);
            }
        }
    }
}
