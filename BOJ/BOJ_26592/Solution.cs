namespace Algorithm.BOJ.BOJ_26592
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_26592/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            while (n-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                double area = double.Parse(input[0]);
                double baseLength = double.Parse(input[1]);

                double height = 2 * area / baseLength;

                Console.WriteLine($"The height of the triangle is {height:F2} units");
            }
        }
    }
}
